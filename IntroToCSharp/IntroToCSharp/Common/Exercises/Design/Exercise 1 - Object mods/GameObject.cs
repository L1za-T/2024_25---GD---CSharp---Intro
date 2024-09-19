namespace IntroToCSharp.Common.Exercise1
{
    /// <summary>
    /// Represents a base game object within our game
    /// </summary>
    public class GameObject
    {
        #region Fields

        private string id;
        private bool isActive;
        private float x, y, z;

        #endregion Fields

        public string ID
        {
            get => id;
            set => id = (value == null) ? "Default ID" : value;
        }

        public bool IsActive { get => isActive; set => isActive = value; }
        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public float Z { get => z; set => z = value; }



        #region Constructors

        public GameObject() : this("Default", false, 0, 0, 0)
        {
        }

        public GameObject(string iD, bool isActive,
            float x, float y, float z)
        {
            id = iD;
            this.isActive = isActive;
            this.x = x; this.y = y; this.z = z;
        }

        #endregion Constructors

        public override string ToString()
        {
            return $"GameObject: {id} at ({x}, {y}, {z})";
        }
    }
}