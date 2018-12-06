using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using StateMachine;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace ExecuteSecondTask
{
    public class Function
    {
        public State FunctionHandler(State input, ILambdaContext context)
        {
            input.Message = input?.Message?.ToUpper();
            return input;
        }
    }
}
