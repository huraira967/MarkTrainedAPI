﻿using MarkTrainedAPI.Models.Brokers;
using System.Data;

namespace MarkTrainedAPI.Services.Foundation.UserTrainingLogs
{
    internal partial class UserTrainingLoggerService
    {
        private void ValidateUserTrainingLog(UserTrainingLog userTrainingLog)
        {
            ValidateUserTrainingLogIsNotNull(userTrainingLog);

            Validate(
                (Rule: IsInvalid(userTrainingLog.UserTrainingId), Parameter: nameof(userTrainingLog.UserTrainingId)));
        }
        //this method is not completed only shows here are all exceptions will be cathced and be thrown
        //use Xception library for exceptions gathering
        private static void ValidateUserTrainingLogIsNotNull(UserTrainingLog userTrainingLog)
        {
            if (userTrainingLog is null)
            {
                throw new NoNullAllowedException();
            }
        }
        private static dynamic IsInvalid(int id) => new
        {
            Condition = id <= 0,
            Message = "Id is required"
        };
        private static void Validate(params (dynamic Rule, string Parameter)[] validations)
        {
            var invalidExamException = new Exception();
            List<Exception> invalidExamExceptions = new List<Exception>();
            foreach ((dynamic rule, string parameter) in validations)
            {
                if (rule.Condition)
                {
                    invalidExamExceptions.Add(new Exception(rule.Message));
                }
            }

            throw invalidExamExceptions.FirstOrDefault();
        }
    }
}
