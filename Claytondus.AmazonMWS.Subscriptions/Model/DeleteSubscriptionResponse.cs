/*******************************************************************************
 * Copyright 2009-2015 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Delete Subscription Response
 * API Version: 2013-07-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:27:11 GMT 2015
 */


using Claytondus.AmazonMWS.Runtime;

namespace Claytondus.AmazonMWS.Subscriptions.Model
{
    public class DeleteSubscriptionResponse : AbstractMwsObject, IMWSResponse
    {

        private DeleteSubscriptionResult _deleteSubscriptionResult;
        private ResponseMetadata _responseMetadata;
        private ResponseHeaderMetadata _responseHeaderMetadata;

        /// <summary>
        /// Gets and sets the DeleteSubscriptionResult property.
        /// </summary>
        public DeleteSubscriptionResult DeleteSubscriptionResult
        {
            get { return this._deleteSubscriptionResult; }
            set { this._deleteSubscriptionResult = value; }
        }

        /// <summary>
        /// Sets the DeleteSubscriptionResult property.
        /// </summary>
        /// <param name="deleteSubscriptionResult">DeleteSubscriptionResult property.</param>
        /// <returns>this instance.</returns>
        public DeleteSubscriptionResponse WithDeleteSubscriptionResult(DeleteSubscriptionResult deleteSubscriptionResult)
        {
            this._deleteSubscriptionResult = deleteSubscriptionResult;
            return this;
        }

        /// <summary>
        /// Checks if DeleteSubscriptionResult property is set.
        /// </summary>
        /// <returns>true if DeleteSubscriptionResult property is set.</returns>
        public bool IsSetDeleteSubscriptionResult()
        {
            return this._deleteSubscriptionResult != null;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// </summary>
        public ResponseMetadata ResponseMetadata
        {
            get { return this._responseMetadata; }
            set { this._responseMetadata = value; }
        }

        /// <summary>
        /// Sets the ResponseMetadata property.
        /// </summary>
        /// <param name="responseMetadata">ResponseMetadata property.</param>
        /// <returns>this instance.</returns>
        public DeleteSubscriptionResponse WithResponseMetadata(ResponseMetadata responseMetadata)
        {
            this._responseMetadata = responseMetadata;
            return this;
        }

        /// <summary>
        /// Checks if ResponseMetadata property is set.
        /// </summary>
        /// <returns>true if ResponseMetadata property is set.</returns>
        public bool IsSetResponseMetadata()
        {
            return this._responseMetadata != null;
        }

        /// <summary>
        /// Gets and sets the ResponseHeaderMetadata property.
        /// </summary>
        public ResponseHeaderMetadata ResponseHeaderMetadata
        {
            get { return this._responseHeaderMetadata; }
            set { this._responseHeaderMetadata = value; }
        }

        /// <summary>
        /// Sets the ResponseHeaderMetadata property.
        /// </summary>
        /// <param name="responseHeaderMetadata">ResponseHeaderMetadata property.</param>
        /// <returns>this instance.</returns>
        public DeleteSubscriptionResponse WithResponseHeaderMetadata(ResponseHeaderMetadata responseHeaderMetadata)
        {
            this._responseHeaderMetadata = responseHeaderMetadata;
            return this;
        }

        /// <summary>
        /// Checks if ResponseHeaderMetadata property is set.
        /// </summary>
        /// <returns>true if ResponseHeaderMetadata property is set.</returns>
        public bool IsSetResponseHeaderMetadata()
        {
            return this._responseHeaderMetadata != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _deleteSubscriptionResult = reader.Read<DeleteSubscriptionResult>("DeleteSubscriptionResult");
            _responseMetadata = reader.Read<ResponseMetadata>("ResponseMetadata");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("DeleteSubscriptionResult", _deleteSubscriptionResult);
            writer.Write("ResponseMetadata", _responseMetadata);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Subscriptions/2013-07-01", "DeleteSubscriptionResponse", this);
        }

        public DeleteSubscriptionResponse() : base()
        {
        }
    }
}
