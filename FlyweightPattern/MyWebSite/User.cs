namespace MyWebSite
{
    class User
    {
        private string name;
        public User(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }
    }
}