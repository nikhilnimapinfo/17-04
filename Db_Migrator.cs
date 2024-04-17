using System;

namespace Interface_WIth_Extensiblity
{
    public class Db_Migrator
    {
        private readonly ILogger _logger;
        public Db_Migrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrator()
        {
            _logger.LogInfo("Migrationn Started,{0}"+DateTime.Now);

            // Migrator Data Base Code

            _logger.LogInfo("Migrationn Finished,{0}" + DateTime.Now);


        }
    
    }
}
