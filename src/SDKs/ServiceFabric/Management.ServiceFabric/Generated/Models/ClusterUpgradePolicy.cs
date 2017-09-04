// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ServiceFabric;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Cluster upgrade policy
    /// </summary>
    public partial class ClusterUpgradePolicy
    {
        /// <summary>
        /// Initializes a new instance of the ClusterUpgradePolicy class.
        /// </summary>
        public ClusterUpgradePolicy()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClusterUpgradePolicy class.
        /// </summary>
        /// <param name="upgradeReplicaSetCheckTimeout">Timeout for replica set
        /// upgrade to complete,it represents .Net TimeSpan</param>
        /// <param name="healthCheckWaitDuration">The length of time to wait
        /// after completing an upgrade domain before performing health checks,
        /// it represents .Net TimeSpan</param>
        /// <param name="healthCheckStableDuration">The length of time that
        /// health checks must pass continuously,it represents .Net
        /// TimeSpan</param>
        /// <param name="healthCheckRetryTimeout">The length of time that
        /// health checks can fail continuously,it represents .Net
        /// TimeSpan</param>
        /// <param name="upgradeTimeout">The upgrade timeout,it represents .Net
        /// TimeSpan</param>
        /// <param name="upgradeDomainTimeout">The timeout for any upgrade
        /// domain,it represents .Net TimeSpan</param>
        /// <param name="healthPolicy">Cluster health Policy</param>
        /// <param name="overrideUserUpgradePolicy">Use the user defined
        /// upgrade policy or not</param>
        /// <param name="forceRestart">Force node to restart or not</param>
        /// <param name="deltaHealthPolicy">Delta health policy</param>
        public ClusterUpgradePolicy(string upgradeReplicaSetCheckTimeout, string healthCheckWaitDuration, string healthCheckStableDuration, string healthCheckRetryTimeout, string upgradeTimeout, string upgradeDomainTimeout, ClusterHealthPolicy healthPolicy, bool? overrideUserUpgradePolicy = default(bool?), bool? forceRestart = default(bool?), ClusterUpgradeDeltaHealthPolicy deltaHealthPolicy = default(ClusterUpgradeDeltaHealthPolicy))
        {
            OverrideUserUpgradePolicy = overrideUserUpgradePolicy;
            ForceRestart = forceRestart;
            UpgradeReplicaSetCheckTimeout = upgradeReplicaSetCheckTimeout;
            HealthCheckWaitDuration = healthCheckWaitDuration;
            HealthCheckStableDuration = healthCheckStableDuration;
            HealthCheckRetryTimeout = healthCheckRetryTimeout;
            UpgradeTimeout = upgradeTimeout;
            UpgradeDomainTimeout = upgradeDomainTimeout;
            HealthPolicy = healthPolicy;
            DeltaHealthPolicy = deltaHealthPolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets use the user defined upgrade policy or not
        /// </summary>
        [JsonProperty(PropertyName = "overrideUserUpgradePolicy")]
        public bool? OverrideUserUpgradePolicy { get; set; }

        /// <summary>
        /// Gets or sets force node to restart or not
        /// </summary>
        [JsonProperty(PropertyName = "forceRestart")]
        public bool? ForceRestart { get; set; }

        /// <summary>
        /// Gets or sets timeout for replica set upgrade to complete,it
        /// represents .Net TimeSpan
        /// </summary>
        [JsonProperty(PropertyName = "upgradeReplicaSetCheckTimeout")]
        public string UpgradeReplicaSetCheckTimeout { get; set; }

        /// <summary>
        /// Gets or sets the length of time to wait after completing an upgrade
        /// domain before performing health checks, it represents .Net TimeSpan
        /// </summary>
        [JsonProperty(PropertyName = "healthCheckWaitDuration")]
        public string HealthCheckWaitDuration { get; set; }

        /// <summary>
        /// Gets or sets the length of time that health checks must pass
        /// continuously,it represents .Net TimeSpan
        /// </summary>
        [JsonProperty(PropertyName = "healthCheckStableDuration")]
        public string HealthCheckStableDuration { get; set; }

        /// <summary>
        /// Gets or sets the length of time that health checks can fail
        /// continuously,it represents .Net TimeSpan
        /// </summary>
        [JsonProperty(PropertyName = "healthCheckRetryTimeout")]
        public string HealthCheckRetryTimeout { get; set; }

        /// <summary>
        /// Gets or sets the upgrade timeout,it represents .Net TimeSpan
        /// </summary>
        [JsonProperty(PropertyName = "upgradeTimeout")]
        public string UpgradeTimeout { get; set; }

        /// <summary>
        /// Gets or sets the timeout for any upgrade domain,it represents .Net
        /// TimeSpan
        /// </summary>
        [JsonProperty(PropertyName = "upgradeDomainTimeout")]
        public string UpgradeDomainTimeout { get; set; }

        /// <summary>
        /// Gets or sets cluster health Policy
        /// </summary>
        [JsonProperty(PropertyName = "healthPolicy")]
        public ClusterHealthPolicy HealthPolicy { get; set; }

        /// <summary>
        /// Gets or sets delta health policy
        /// </summary>
        [JsonProperty(PropertyName = "deltaHealthPolicy")]
        public ClusterUpgradeDeltaHealthPolicy DeltaHealthPolicy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (UpgradeReplicaSetCheckTimeout == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UpgradeReplicaSetCheckTimeout");
            }
            if (HealthCheckWaitDuration == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HealthCheckWaitDuration");
            }
            if (HealthCheckStableDuration == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HealthCheckStableDuration");
            }
            if (HealthCheckRetryTimeout == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HealthCheckRetryTimeout");
            }
            if (UpgradeTimeout == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UpgradeTimeout");
            }
            if (UpgradeDomainTimeout == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UpgradeDomainTimeout");
            }
            if (HealthPolicy == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HealthPolicy");
            }
            if (HealthPolicy != null)
            {
                HealthPolicy.Validate();
            }
            if (DeltaHealthPolicy != null)
            {
                DeltaHealthPolicy.Validate();
            }
        }
    }
}