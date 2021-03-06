// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Consumption.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Consumption;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An usage detail resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class UsageDetail : Resource
    {
        /// <summary>
        /// Initializes a new instance of the UsageDetail class.
        /// </summary>
        public UsageDetail()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UsageDetail class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="billingPeriodId">The id of the billing period resource
        /// that the usage belongs to.</param>
        /// <param name="invoiceId">The id of the invoice resource that the
        /// usage belongs to.</param>
        /// <param name="usageStart">The start of the date time range covered
        /// by the usage detail.</param>
        /// <param name="usageEnd">The end of the date time range covered by
        /// the usage detail.</param>
        /// <param name="instanceName">The name of the resource instance that
        /// the usage is about.</param>
        /// <param name="instanceId">The uri of the resource instance that the
        /// usage is about.</param>
        /// <param name="instanceLocation">The location of the resource
        /// instance that the usage is about.</param>
        /// <param name="currency">The ISO currency in which the meter is
        /// charged, for example, USD.</param>
        /// <param name="usageQuantity">The quantity of usage.</param>
        /// <param name="billableQuantity">The billable usage quantity.</param>
        /// <param name="pretaxCost">The amount of cost before tax.</param>
        /// <param name="isEstimated">The estimated usage is subject to
        /// change.</param>
        /// <param name="meterId">The meter id.</param>
        /// <param name="meterDetails">The details about the meter. By default
        /// this is not populated, unless it's specified in $expand.</param>
        /// <param name="additionalProperties">The list of key/value pairs for
        /// the additional properties, in the format 'key':'value' where key =
        /// the field name, and value = the field value. By default this is not
        /// populated, unless it's specified in $expand.</param>
        public UsageDetail(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string billingPeriodId = default(string), string invoiceId = default(string), System.DateTime? usageStart = default(System.DateTime?), System.DateTime? usageEnd = default(System.DateTime?), string instanceName = default(string), string instanceId = default(string), string instanceLocation = default(string), string currency = default(string), decimal? usageQuantity = default(decimal?), decimal? billableQuantity = default(decimal?), decimal? pretaxCost = default(decimal?), bool? isEstimated = default(bool?), string meterId = default(string), MeterDetails meterDetails = default(MeterDetails), IDictionary<string, string> additionalProperties = default(IDictionary<string, string>))
            : base(id, name, type, tags)
        {
            BillingPeriodId = billingPeriodId;
            InvoiceId = invoiceId;
            UsageStart = usageStart;
            UsageEnd = usageEnd;
            InstanceName = instanceName;
            InstanceId = instanceId;
            InstanceLocation = instanceLocation;
            Currency = currency;
            UsageQuantity = usageQuantity;
            BillableQuantity = billableQuantity;
            PretaxCost = pretaxCost;
            IsEstimated = isEstimated;
            MeterId = meterId;
            MeterDetails = meterDetails;
            AdditionalProperties = additionalProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the id of the billing period resource that the usage belongs
        /// to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingPeriodId")]
        public string BillingPeriodId { get; private set; }

        /// <summary>
        /// Gets the id of the invoice resource that the usage belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceId")]
        public string InvoiceId { get; private set; }

        /// <summary>
        /// Gets the start of the date time range covered by the usage detail.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usageStart")]
        public System.DateTime? UsageStart { get; private set; }

        /// <summary>
        /// Gets the end of the date time range covered by the usage detail.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usageEnd")]
        public System.DateTime? UsageEnd { get; private set; }

        /// <summary>
        /// Gets the name of the resource instance that the usage is about.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceName")]
        public string InstanceName { get; private set; }

        /// <summary>
        /// Gets the uri of the resource instance that the usage is about.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceId")]
        public string InstanceId { get; private set; }

        /// <summary>
        /// Gets the location of the resource instance that the usage is about.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceLocation")]
        public string InstanceLocation { get; private set; }

        /// <summary>
        /// Gets the ISO currency in which the meter is charged, for example,
        /// USD.
        /// </summary>
        [JsonProperty(PropertyName = "properties.currency")]
        public string Currency { get; private set; }

        /// <summary>
        /// Gets the quantity of usage.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usageQuantity")]
        public decimal? UsageQuantity { get; private set; }

        /// <summary>
        /// Gets the billable usage quantity.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billableQuantity")]
        public decimal? BillableQuantity { get; private set; }

        /// <summary>
        /// Gets the amount of cost before tax.
        /// </summary>
        [JsonProperty(PropertyName = "properties.pretaxCost")]
        public decimal? PretaxCost { get; private set; }

        /// <summary>
        /// Gets the estimated usage is subject to change.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isEstimated")]
        public bool? IsEstimated { get; private set; }

        /// <summary>
        /// Gets the meter id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.meterId")]
        public string MeterId { get; private set; }

        /// <summary>
        /// Gets the details about the meter. By default this is not populated,
        /// unless it's specified in $expand.
        /// </summary>
        [JsonProperty(PropertyName = "properties.meterDetails")]
        public MeterDetails MeterDetails { get; private set; }

        /// <summary>
        /// Gets the list of key/value pairs for the additional properties, in
        /// the format 'key':'value' where key = the field name, and value =
        /// the field value. By default this is not populated, unless it's
        /// specified in $expand.
        /// </summary>
        [JsonProperty(PropertyName = "properties.additionalProperties")]
        public IDictionary<string, string> AdditionalProperties { get; private set; }

    }
}
