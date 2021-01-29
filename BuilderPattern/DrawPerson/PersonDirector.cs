namespace DrawPerson
{
    class PersonDirector
    {
        public static void CreatePerson(PersonBuilder pb)
        {
            pb.BuildHead();
            pb.BuildBody();
            pb.BuildArmLeft();
            pb.BuildArmRight();
            pb.BuildLegLeft();
            pb.BuildLegRight();
        }
    }
}
