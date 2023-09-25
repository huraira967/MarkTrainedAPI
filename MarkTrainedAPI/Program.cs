using MarkTrainedAPI.Models.Brokers;
using StorageBrokers;
using System.ComponentModel;
using System.Data;

namespace MarkTrainedAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}



namespace TrainingLogging
    {
        //Models
        internal class UsertTrainingLoggingDto
    {
        public UserTrainingLog UserTrainingLog { get; set; }
        public ExternalSystemUserTrainingLog ExternalUserTrainingLog { get; set; }

    }
    internal interface TrainingLogger
    {
        void LogUserTraining(UsertTrainingLoggingDto message);
        void LogExternalSystemUserTraining(UsertTrainingLoggingDto message);
    }
    internal class DbTrainingLogger : TrainingLogger
    {

        public DbTrainingLogger()
        {
            
        }
        public void LogExternalSystemUserTraining(UsertTrainingLoggingDto message)
        {
            throw new NotImplementedException();
        }

        public void LogUserTraining(UsertTrainingLoggingDto message)
        {
            throw new NotImplementedException();
        }
    }
}
namespace MarkTrained
    {
        //Model
  
    class MarkTrainedDTO
    {
        public int UserTrainingId { get; set; }
        //... other poyload properties
    }
    //Services

    interface IMarkTrained
    {
        ValueTask<UserTraining> MarkTrained(int trainingId, UserTraining trainingData);
    }
    internal class TrainerMarkTrained : IMarkTrained
    {
        public async ValueTask<UserTraining> MarkTrained(int trainingId, UserTraining trainingData)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Trainer Marked Training as Trained");
            });
            return trainingData;
        }
    }
    internal class SelfMarkTrained : IMarkTrained
    {
        public async ValueTask<UserTraining> MarkTrained(int trainingId, UserTraining trainingData)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Trainer Marked Training as Trained");
            });
            return trainingData;
        }
    }
    internal class ExternalMarkTrained : IMarkTrained
    {
        public async ValueTask<UserTraining> MarkTrained(int trainingId, UserTraining trainingData)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Trainer Marked Training as Trained");
            });
            return trainingData;
        }
    }
    internal class PCGMarkTrained : IMarkTrained
    {
        public async ValueTask<UserTraining> MarkTrained(int trainingId, UserTraining trainingData)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Trainer Marked Training as Trained");
            });
            return trainingData;
        }
    }
    internal class SupervisorMarkTrained : IMarkTrained
    {
        public async ValueTask<UserTraining> MarkTrained(int trainingId, UserTraining trainingData)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Trainer Marked Training as Trained");
            });
            return trainingData;
        }
    }
    internal class QuizPassMarkTrained : IMarkTrained
    {
        public async ValueTask<UserTraining> MarkTrained(int trainingId, UserTraining trainingData)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Trainer Marked Training as Trained");
            });
            return trainingData;
        }
    }
    internal class MaterialCompleteMarkTrained : IMarkTrained
    {
        public async ValueTask<UserTraining> MarkTrained(int trainingId, UserTraining trainingData)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Trainer Marked Training as Trained");
            });
            return trainingData;
        }
    }
    internal class OFLMarkTrained : IMarkTrained
    {
        public async ValueTask<UserTraining> MarkTrained(int trainingId, UserTraining trainingData)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Trainer Marked Training as Trained");
            });
            return trainingData;
        }
    }
    internal class TopyxMarkTrained : IMarkTrained
    {
        public async ValueTask<UserTraining> MarkTrained(int trainingId, UserTraining trainingData)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Trainer Marked Training as Trained");
            });
            return trainingData;
        }
    }
    internal class ReliasMarkTrained : IMarkTrained
    {
        public async ValueTask<UserTraining> MarkTrained(int trainingId, UserTraining trainingData)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Trainer Marked Training as Trained");
            });
            return trainingData;
        }
    }
}