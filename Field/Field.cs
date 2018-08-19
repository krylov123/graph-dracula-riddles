using System.Collections.Generic;

namespace GraphDracula.Field
{
    public class Field
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public string OriginalFieldString { get; private set; }
        public string[][] WalkingLayerCoordinates { get; set; }
        public string[][] BombsLayerCoordinates { get; set; }
        public string[][] BugsLayerCoordinates { get; set; }
        public string[][] PlayersLayerCoordinates { get; set; }

        public Dictionary<string, string> Snippets { get; set; }

        public Field()
        {
            ClearLayers();
        }

        public void UpdateFromString(string field)
        {
            OriginalFieldString = field;
            ClearLayers();
            ParseLayers();
        }

        public void UpdateSettings(string type, string value)
        {
            if (type == "field_width") Width = int.Parse(value);
            if (type == "field_height") Height = int.Parse(value);
        }

        public void ClearLayers()
        {
            Snippets = new Dictionary<string, string>();
        }

        public void ParseLayers()
        {
            foreach (int[] coordinates in ParseObjectsCoordinate("C"))
            {
                string coordinate = coordinates[0] + "_" + coordinates[1];
                Snippets.Add(coordinate, "C");
            }
        }

        //Fast calculation any game object coordinates from original field string (instead of looping parsed object)
        //use that when you need quickly determine coords of particular game object or objects (eg P, for players)
        private List<int[]> ParseObjectsCoordinate(string objectName, string field = null)
        {
            if (field == null) field = OriginalFieldString;
            List<int[]> result = new List<int[]>();
            string[] splitted = field.Split(objectName[0]);
            string commaCountableString = "";
            foreach (string s in splitted)
            {
                commaCountableString += s;
                int count = commaCountableString.Split(',').Length;
                int y = count / Width;
                int x = count % Width;
                result.Add(new int[] {x, y});
            }

            return result;
        }
    }
}