//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//

/*
 * Do not modify this file. This file is generated from the cognito-sync-2014-06-30.normal.json service model.
 */
using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CognitoSync.Model
{
    ///<summary>
    /// CognitoSync exception
    /// </summary>
    public class InternalErrorException : AmazonCognitoSyncException 
    {
        /// <summary>
        /// Constructs a new InternalErrorException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public InternalErrorException(string message) 
            : base(message) {}
          
        public InternalErrorException(string message, Exception innerException) 
            : base(message, innerException) {}
            
        public InternalErrorException(Exception innerException) 
            : base(innerException) {}
            
        public InternalErrorException(string message, Exception innerException, ErrorType errorType, string errorCode, string RequestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, RequestId, statusCode) {}

        public InternalErrorException(string message, ErrorType errorType, string errorCode, string RequestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, RequestId, statusCode) {}

    }
}
