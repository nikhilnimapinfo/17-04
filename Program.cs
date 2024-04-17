namespace Interface_WIth_Extensiblity
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbmigrator=new Db_Migrator(new FileLogger("D:\\ New Text Document.txt")); //create File That Location
            dbmigrator.Migrator();
        }
    }
}
