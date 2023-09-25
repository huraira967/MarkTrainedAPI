using MarkTrainedAPI.Models.Brokers;

namespace StorageBrokers
{
    internal partial class StorageBroker
    {
        //Db table
        //public DbSet<UserTrainingLog> UserTrainingLogs { get; set; }
        public async ValueTask<UserTrainingLog> InsertUserTrainingLog(
            UserTrainingLog userTrainingLog) =>  await Insert(userTrainingLog);
        
    }
}
