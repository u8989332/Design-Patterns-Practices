namespace Greeting
{
    class Director
    {
        private Builder builder;
        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.MakeTitle("Greeting");
            builder.MakeString("From morning to afternoon");
            builder.MakeItems(new string[]{
                "Good morning!",
                "Good afternoon!"
            });
            builder.MakeString("evening");
            builder.MakeItems(new string[]{
                "Good evening!",
                "Good night!"
            });
            builder.Close();
        }
    }
}
