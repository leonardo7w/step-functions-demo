using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StateMachine;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace ExecuteFirstTask
{
    public class Function
    {
        public State FunctionHandler(State input, ILambdaContext context)
        {
            input.Message = input?.Message?.ToLower();
            return input;
        }
    }
}
