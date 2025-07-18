namespace Azure.ResourceManager.Dns
{
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.DnsAaaaRecordData))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.DnsARecordData))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.DnsBaseRecordData))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.DnsCaaRecordData))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.DnsCnameRecordData))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.DnsDSRecordData))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.DnsMXRecordData))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.DnsNaptrRecordData))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.DnsNSRecordData))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.DnsPtrRecordData))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.DnsRecordData))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.DnssecConfigData))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.DnssecConfigResource))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.DnsSoaRecordData))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.DnsSrvRecordData))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.DnsTlsaRecordData))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.DnsTxtRecordData))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.DnsZoneData))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.Models.DelegationSignerInfo))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.Models.DnsAaaaRecordInfo))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.Models.DnsARecordInfo))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.Models.DnsCaaRecordInfo))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.Models.DnsDSRecordInfo))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.Models.DnsMXRecordInfo))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.Models.DnsNaptrRecordInfo))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.Models.DnsNSRecordInfo))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.Models.DnsPtrRecordInfo))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.Models.DnsResourceReference))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.Models.DnsResourceReferenceContent))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.Models.DnsResourceReferenceResult))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.Models.DnsSigningKey))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.Models.DnsSoaRecordInfo))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.Models.DnsSrvRecordInfo))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.Models.DnsTlsaRecordInfo))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.Models.DnsTxtRecordInfo))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.Models.DnsZonePatch))]
    [System.ClientModel.Primitives.ModelReaderWriterBuildableAttribute(typeof(Azure.ResourceManager.Dns.Models.DSRecordDigest))]
    public partial class AzureResourceManagerDnsContext : System.ClientModel.Primitives.ModelReaderWriterContext
    {
        internal AzureResourceManagerDnsContext() { }
        public static Azure.ResourceManager.Dns.AzureResourceManagerDnsContext Default { get { throw null; } }
        protected override bool TryGetTypeBuilderCore(System.Type type, out System.ClientModel.Primitives.ModelReaderWriterTypeBuilder builder) { throw null; }
    }
    public partial class DnsAaaaRecordCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsAaaaRecordResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsAaaaRecordResource>, System.Collections.IEnumerable
    {
        protected DnsAaaaRecordCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsAaaaRecordResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string aaaaRecordName, Azure.ResourceManager.Dns.DnsAaaaRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsAaaaRecordResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string aaaaRecordName, Azure.ResourceManager.Dns.DnsAaaaRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string aaaaRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string aaaaRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsAaaaRecordResource> Get(string aaaaRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Dns.DnsAaaaRecordResource> GetAll(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Dns.DnsAaaaRecordResource> GetAllAsync(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsAaaaRecordResource>> GetAsync(string aaaaRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Dns.DnsAaaaRecordResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsAaaaRecordResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Dns.DnsAaaaRecordResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsAaaaRecordResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DnsAaaaRecordData : Azure.ResourceManager.Dns.DnsBaseRecordData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsAaaaRecordData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsAaaaRecordData>
    {
        public DnsAaaaRecordData() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsAaaaRecordInfo> DnsAaaaRecords { get { throw null; } }
        Azure.ResourceManager.Dns.DnsAaaaRecordData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsAaaaRecordData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsAaaaRecordData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.DnsAaaaRecordData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsAaaaRecordData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsAaaaRecordData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsAaaaRecordData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsAaaaRecordResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DnsAaaaRecordResource() { }
        public virtual Azure.ResourceManager.Dns.DnsAaaaRecordData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string zoneName, string aaaaRecordName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsAaaaRecordResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsAaaaRecordResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsAaaaRecordResource> Update(Azure.ResourceManager.Dns.DnsAaaaRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsAaaaRecordResource>> UpdateAsync(Azure.ResourceManager.Dns.DnsAaaaRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DnsARecordCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsARecordResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsARecordResource>, System.Collections.IEnumerable
    {
        protected DnsARecordCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsARecordResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string aRecordName, Azure.ResourceManager.Dns.DnsARecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsARecordResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string aRecordName, Azure.ResourceManager.Dns.DnsARecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string aRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string aRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsARecordResource> Get(string aRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Dns.DnsARecordResource> GetAll(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Dns.DnsARecordResource> GetAllAsync(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsARecordResource>> GetAsync(string aRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Dns.DnsARecordResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsARecordResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Dns.DnsARecordResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsARecordResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DnsARecordData : Azure.ResourceManager.Dns.DnsBaseRecordData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsARecordData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsARecordData>
    {
        public DnsARecordData() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsARecordInfo> DnsARecords { get { throw null; } }
        Azure.ResourceManager.Dns.DnsARecordData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsARecordData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsARecordData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.DnsARecordData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsARecordData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsARecordData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsARecordData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsARecordResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DnsARecordResource() { }
        public virtual Azure.ResourceManager.Dns.DnsARecordData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string zoneName, string aRecordName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsARecordResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsARecordResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsARecordResource> Update(Azure.ResourceManager.Dns.DnsARecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsARecordResource>> UpdateAsync(Azure.ResourceManager.Dns.DnsARecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DnsBaseRecordData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsBaseRecordData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsBaseRecordData>
    {
        public DnsBaseRecordData() { }
        public Azure.ETag? ETag { get { throw null; } set { } }
        public string Fqdn { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Metadata { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
        public Azure.Core.ResourceIdentifier TargetResourceId { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier TrafficManagementProfileId { get { throw null; } set { } }
        public long? TtlInSeconds { get { throw null; } set { } }
        Azure.ResourceManager.Dns.DnsBaseRecordData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsBaseRecordData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsBaseRecordData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.DnsBaseRecordData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsBaseRecordData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsBaseRecordData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsBaseRecordData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsCaaRecordCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsCaaRecordResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsCaaRecordResource>, System.Collections.IEnumerable
    {
        protected DnsCaaRecordCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsCaaRecordResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string caaRecordName, Azure.ResourceManager.Dns.DnsCaaRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsCaaRecordResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string caaRecordName, Azure.ResourceManager.Dns.DnsCaaRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string caaRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string caaRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsCaaRecordResource> Get(string caaRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Dns.DnsCaaRecordResource> GetAll(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Dns.DnsCaaRecordResource> GetAllAsync(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsCaaRecordResource>> GetAsync(string caaRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Dns.DnsCaaRecordResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsCaaRecordResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Dns.DnsCaaRecordResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsCaaRecordResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DnsCaaRecordData : Azure.ResourceManager.Dns.DnsBaseRecordData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsCaaRecordData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsCaaRecordData>
    {
        public DnsCaaRecordData() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsCaaRecordInfo> DnsCaaRecords { get { throw null; } }
        Azure.ResourceManager.Dns.DnsCaaRecordData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsCaaRecordData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsCaaRecordData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.DnsCaaRecordData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsCaaRecordData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsCaaRecordData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsCaaRecordData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsCaaRecordResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DnsCaaRecordResource() { }
        public virtual Azure.ResourceManager.Dns.DnsCaaRecordData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string zoneName, string caaRecordName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsCaaRecordResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsCaaRecordResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsCaaRecordResource> Update(Azure.ResourceManager.Dns.DnsCaaRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsCaaRecordResource>> UpdateAsync(Azure.ResourceManager.Dns.DnsCaaRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DnsCnameRecordCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsCnameRecordResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsCnameRecordResource>, System.Collections.IEnumerable
    {
        protected DnsCnameRecordCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsCnameRecordResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string cnameRecordName, Azure.ResourceManager.Dns.DnsCnameRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsCnameRecordResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string cnameRecordName, Azure.ResourceManager.Dns.DnsCnameRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string cnameRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string cnameRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsCnameRecordResource> Get(string cnameRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Dns.DnsCnameRecordResource> GetAll(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Dns.DnsCnameRecordResource> GetAllAsync(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsCnameRecordResource>> GetAsync(string cnameRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Dns.DnsCnameRecordResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsCnameRecordResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Dns.DnsCnameRecordResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsCnameRecordResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DnsCnameRecordData : Azure.ResourceManager.Dns.DnsBaseRecordData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsCnameRecordData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsCnameRecordData>
    {
        public DnsCnameRecordData() { }
        public string Cname { get { throw null; } set { } }
        Azure.ResourceManager.Dns.DnsCnameRecordData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsCnameRecordData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsCnameRecordData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.DnsCnameRecordData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsCnameRecordData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsCnameRecordData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsCnameRecordData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsCnameRecordResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DnsCnameRecordResource() { }
        public virtual Azure.ResourceManager.Dns.DnsCnameRecordData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string zoneName, string cnameRecordName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsCnameRecordResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsCnameRecordResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsCnameRecordResource> Update(Azure.ResourceManager.Dns.DnsCnameRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsCnameRecordResource>> UpdateAsync(Azure.ResourceManager.Dns.DnsCnameRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DnsDSRecordCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsDSRecordResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsDSRecordResource>, System.Collections.IEnumerable
    {
        protected DnsDSRecordCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsDSRecordResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string relativeRecordSetName, Azure.ResourceManager.Dns.DnsDSRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsDSRecordResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string relativeRecordSetName, Azure.ResourceManager.Dns.DnsDSRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string relativeRecordSetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string relativeRecordSetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsDSRecordResource> Get(string relativeRecordSetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Dns.DnsDSRecordResource> GetAll(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Dns.DnsDSRecordResource> GetAllAsync(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsDSRecordResource>> GetAsync(string relativeRecordSetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Dns.DnsDSRecordResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsDSRecordResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Dns.DnsDSRecordResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsDSRecordResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DnsDSRecordData : Azure.ResourceManager.Dns.DnsBaseRecordData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsDSRecordData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsDSRecordData>
    {
        public DnsDSRecordData() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsDSRecordInfo> DnsDSRecords { get { throw null; } }
        Azure.ResourceManager.Dns.DnsDSRecordData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsDSRecordData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsDSRecordData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.DnsDSRecordData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsDSRecordData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsDSRecordData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsDSRecordData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsDSRecordResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DnsDSRecordResource() { }
        public virtual Azure.ResourceManager.Dns.DnsDSRecordData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string zoneName, string relativeRecordSetName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsDSRecordResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsDSRecordResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsDSRecordResource> Update(Azure.ResourceManager.Dns.DnsDSRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsDSRecordResource>> UpdateAsync(Azure.ResourceManager.Dns.DnsDSRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class DnsExtensions
    {
        public static Azure.ResourceManager.Dns.DnsAaaaRecordResource GetDnsAaaaRecordResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Dns.DnsARecordResource GetDnsARecordResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Dns.DnsCaaRecordResource GetDnsCaaRecordResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Dns.DnsCnameRecordResource GetDnsCnameRecordResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Dns.DnsDSRecordResource GetDnsDSRecordResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Dns.DnsMXRecordResource GetDnsMXRecordResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Dns.DnsNaptrRecordResource GetDnsNaptrRecordResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Dns.DnsNSRecordResource GetDnsNSRecordResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Dns.DnsPtrRecordResource GetDnsPtrRecordResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Dns.Models.DnsResourceReferenceResult> GetDnsResourceReferencesByTargetResources(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.Dns.Models.DnsResourceReferenceContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.Models.DnsResourceReferenceResult>> GetDnsResourceReferencesByTargetResourcesAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.Dns.Models.DnsResourceReferenceContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Dns.DnssecConfigResource GetDnssecConfigResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Dns.DnsSoaRecordResource GetDnsSoaRecordResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Dns.DnsSrvRecordResource GetDnsSrvRecordResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Dns.DnsTlsaRecordResource GetDnsTlsaRecordResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Dns.DnsTxtRecordResource GetDnsTxtRecordResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Dns.DnsZoneResource> GetDnsZone(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string zoneName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsZoneResource>> GetDnsZoneAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string zoneName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Dns.DnsZoneResource GetDnsZoneResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Dns.DnsZoneCollection GetDnsZones(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Dns.DnsZoneResource> GetDnsZones(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Dns.DnsZoneResource> GetDnsZonesAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DnsMXRecordCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsMXRecordResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsMXRecordResource>, System.Collections.IEnumerable
    {
        protected DnsMXRecordCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsMXRecordResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string mxRecordName, Azure.ResourceManager.Dns.DnsMXRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsMXRecordResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string mxRecordName, Azure.ResourceManager.Dns.DnsMXRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string mxRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string mxRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsMXRecordResource> Get(string mxRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Dns.DnsMXRecordResource> GetAll(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Dns.DnsMXRecordResource> GetAllAsync(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsMXRecordResource>> GetAsync(string mxRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Dns.DnsMXRecordResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsMXRecordResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Dns.DnsMXRecordResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsMXRecordResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DnsMXRecordData : Azure.ResourceManager.Dns.DnsBaseRecordData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsMXRecordData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsMXRecordData>
    {
        public DnsMXRecordData() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsMXRecordInfo> DnsMXRecords { get { throw null; } }
        Azure.ResourceManager.Dns.DnsMXRecordData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsMXRecordData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsMXRecordData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.DnsMXRecordData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsMXRecordData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsMXRecordData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsMXRecordData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsMXRecordResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DnsMXRecordResource() { }
        public virtual Azure.ResourceManager.Dns.DnsMXRecordData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string zoneName, string mxRecordName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsMXRecordResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsMXRecordResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsMXRecordResource> Update(Azure.ResourceManager.Dns.DnsMXRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsMXRecordResource>> UpdateAsync(Azure.ResourceManager.Dns.DnsMXRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DnsNaptrRecordCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsNaptrRecordResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsNaptrRecordResource>, System.Collections.IEnumerable
    {
        protected DnsNaptrRecordCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsNaptrRecordResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string relativeRecordSetName, Azure.ResourceManager.Dns.DnsNaptrRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsNaptrRecordResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string relativeRecordSetName, Azure.ResourceManager.Dns.DnsNaptrRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string relativeRecordSetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string relativeRecordSetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsNaptrRecordResource> Get(string relativeRecordSetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Dns.DnsNaptrRecordResource> GetAll(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Dns.DnsNaptrRecordResource> GetAllAsync(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsNaptrRecordResource>> GetAsync(string relativeRecordSetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Dns.DnsNaptrRecordResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsNaptrRecordResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Dns.DnsNaptrRecordResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsNaptrRecordResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DnsNaptrRecordData : Azure.ResourceManager.Dns.DnsBaseRecordData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsNaptrRecordData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsNaptrRecordData>
    {
        public DnsNaptrRecordData() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsNaptrRecordInfo> DnsNaptrRecords { get { throw null; } }
        Azure.ResourceManager.Dns.DnsNaptrRecordData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsNaptrRecordData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsNaptrRecordData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.DnsNaptrRecordData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsNaptrRecordData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsNaptrRecordData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsNaptrRecordData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsNaptrRecordResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DnsNaptrRecordResource() { }
        public virtual Azure.ResourceManager.Dns.DnsNaptrRecordData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string zoneName, string relativeRecordSetName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsNaptrRecordResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsNaptrRecordResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsNaptrRecordResource> Update(Azure.ResourceManager.Dns.DnsNaptrRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsNaptrRecordResource>> UpdateAsync(Azure.ResourceManager.Dns.DnsNaptrRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DnsNSRecordCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsNSRecordResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsNSRecordResource>, System.Collections.IEnumerable
    {
        protected DnsNSRecordCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsNSRecordResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string nsRecordName, Azure.ResourceManager.Dns.DnsNSRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsNSRecordResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string nsRecordName, Azure.ResourceManager.Dns.DnsNSRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string nsRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string nsRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsNSRecordResource> Get(string nsRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Dns.DnsNSRecordResource> GetAll(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Dns.DnsNSRecordResource> GetAllAsync(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsNSRecordResource>> GetAsync(string nsRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Dns.DnsNSRecordResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsNSRecordResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Dns.DnsNSRecordResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsNSRecordResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DnsNSRecordData : Azure.ResourceManager.Dns.DnsBaseRecordData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsNSRecordData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsNSRecordData>
    {
        public DnsNSRecordData() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsNSRecordInfo> DnsNSRecords { get { throw null; } }
        Azure.ResourceManager.Dns.DnsNSRecordData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsNSRecordData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsNSRecordData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.DnsNSRecordData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsNSRecordData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsNSRecordData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsNSRecordData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsNSRecordResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DnsNSRecordResource() { }
        public virtual Azure.ResourceManager.Dns.DnsNSRecordData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string zoneName, string nsRecordName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsNSRecordResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsNSRecordResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsNSRecordResource> Update(Azure.ResourceManager.Dns.DnsNSRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsNSRecordResource>> UpdateAsync(Azure.ResourceManager.Dns.DnsNSRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DnsPtrRecordCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsPtrRecordResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsPtrRecordResource>, System.Collections.IEnumerable
    {
        protected DnsPtrRecordCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsPtrRecordResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string ptrRecordName, Azure.ResourceManager.Dns.DnsPtrRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsPtrRecordResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string ptrRecordName, Azure.ResourceManager.Dns.DnsPtrRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string ptrRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string ptrRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsPtrRecordResource> Get(string ptrRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Dns.DnsPtrRecordResource> GetAll(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Dns.DnsPtrRecordResource> GetAllAsync(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsPtrRecordResource>> GetAsync(string ptrRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Dns.DnsPtrRecordResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsPtrRecordResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Dns.DnsPtrRecordResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsPtrRecordResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DnsPtrRecordData : Azure.ResourceManager.Dns.DnsBaseRecordData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsPtrRecordData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsPtrRecordData>
    {
        public DnsPtrRecordData() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsPtrRecordInfo> DnsPtrRecords { get { throw null; } }
        Azure.ResourceManager.Dns.DnsPtrRecordData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsPtrRecordData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsPtrRecordData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.DnsPtrRecordData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsPtrRecordData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsPtrRecordData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsPtrRecordData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsPtrRecordResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DnsPtrRecordResource() { }
        public virtual Azure.ResourceManager.Dns.DnsPtrRecordData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string zoneName, string ptrRecordName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsPtrRecordResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsPtrRecordResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsPtrRecordResource> Update(Azure.ResourceManager.Dns.DnsPtrRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsPtrRecordResource>> UpdateAsync(Azure.ResourceManager.Dns.DnsPtrRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DnsRecordData : Azure.ResourceManager.Dns.DnsBaseRecordData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsRecordData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsRecordData>
    {
        public DnsRecordData() { }
        public string Cname { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsAaaaRecordInfo> DnsAaaaRecords { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsARecordInfo> DnsARecords { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsCaaRecordInfo> DnsCaaRecords { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsDSRecordInfo> DnsDSRecords { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsMXRecordInfo> DnsMXRecords { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsNaptrRecordInfo> DnsNaptrRecords { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsNSRecordInfo> DnsNSRecords { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsPtrRecordInfo> DnsPtrRecords { get { throw null; } }
        public Azure.ResourceManager.Dns.Models.DnsSoaRecordInfo DnsSoaRecordInfo { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsSrvRecordInfo> DnsSrvRecords { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsTlsaRecordInfo> DnsTlsaRecords { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsTxtRecordInfo> DnsTxtRecords { get { throw null; } }
        public Azure.ResourceManager.Dns.Models.DnsRecordType RecordType { get { throw null; } }
        Azure.ResourceManager.Dns.DnsRecordData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsRecordData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsRecordData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.DnsRecordData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsRecordData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsRecordData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsRecordData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnssecConfigData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnssecConfigData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnssecConfigData>
    {
        internal DnssecConfigData() { }
        public Azure.ETag? ETag { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Dns.Models.DnsSigningKey> SigningKeys { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.DnssecConfigData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnssecConfigData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnssecConfigData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.DnssecConfigData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnssecConfigData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnssecConfigData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnssecConfigData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnssecConfigResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnssecConfigData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnssecConfigData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DnssecConfigResource() { }
        public virtual Azure.ResourceManager.Dns.DnssecConfigData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnssecConfigResource> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnssecConfigResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string zoneName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnssecConfigResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnssecConfigResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Dns.DnssecConfigData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnssecConfigData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnssecConfigData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.DnssecConfigData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnssecConfigData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnssecConfigData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnssecConfigData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsSoaRecordCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsSoaRecordResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsSoaRecordResource>, System.Collections.IEnumerable
    {
        protected DnsSoaRecordCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsSoaRecordResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string soaRecordName, Azure.ResourceManager.Dns.DnsSoaRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsSoaRecordResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string soaRecordName, Azure.ResourceManager.Dns.DnsSoaRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string soaRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string soaRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsSoaRecordResource> Get(string soaRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Dns.DnsSoaRecordResource> GetAll(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Dns.DnsSoaRecordResource> GetAllAsync(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsSoaRecordResource>> GetAsync(string soaRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Dns.DnsSoaRecordResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsSoaRecordResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Dns.DnsSoaRecordResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsSoaRecordResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DnsSoaRecordData : Azure.ResourceManager.Dns.DnsBaseRecordData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsSoaRecordData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsSoaRecordData>
    {
        public DnsSoaRecordData() { }
        public Azure.ResourceManager.Dns.Models.DnsSoaRecordInfo DnsSoaRecord { get { throw null; } set { } }
        Azure.ResourceManager.Dns.DnsSoaRecordData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsSoaRecordData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsSoaRecordData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.DnsSoaRecordData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsSoaRecordData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsSoaRecordData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsSoaRecordData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsSoaRecordResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DnsSoaRecordResource() { }
        public virtual Azure.ResourceManager.Dns.DnsSoaRecordData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string zoneName, string soaRecordName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsSoaRecordResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsSoaRecordResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsSoaRecordResource> Update(Azure.ResourceManager.Dns.DnsSoaRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsSoaRecordResource>> UpdateAsync(Azure.ResourceManager.Dns.DnsSoaRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DnsSrvRecordCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsSrvRecordResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsSrvRecordResource>, System.Collections.IEnumerable
    {
        protected DnsSrvRecordCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsSrvRecordResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string srvRecordName, Azure.ResourceManager.Dns.DnsSrvRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsSrvRecordResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string srvRecordName, Azure.ResourceManager.Dns.DnsSrvRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string srvRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string srvRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsSrvRecordResource> Get(string srvRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Dns.DnsSrvRecordResource> GetAll(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Dns.DnsSrvRecordResource> GetAllAsync(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsSrvRecordResource>> GetAsync(string srvRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Dns.DnsSrvRecordResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsSrvRecordResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Dns.DnsSrvRecordResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsSrvRecordResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DnsSrvRecordData : Azure.ResourceManager.Dns.DnsBaseRecordData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsSrvRecordData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsSrvRecordData>
    {
        public DnsSrvRecordData() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsSrvRecordInfo> DnsSrvRecords { get { throw null; } }
        Azure.ResourceManager.Dns.DnsSrvRecordData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsSrvRecordData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsSrvRecordData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.DnsSrvRecordData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsSrvRecordData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsSrvRecordData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsSrvRecordData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsSrvRecordResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DnsSrvRecordResource() { }
        public virtual Azure.ResourceManager.Dns.DnsSrvRecordData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string zoneName, string srvRecordName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsSrvRecordResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsSrvRecordResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsSrvRecordResource> Update(Azure.ResourceManager.Dns.DnsSrvRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsSrvRecordResource>> UpdateAsync(Azure.ResourceManager.Dns.DnsSrvRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DnsTlsaRecordCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsTlsaRecordResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsTlsaRecordResource>, System.Collections.IEnumerable
    {
        protected DnsTlsaRecordCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsTlsaRecordResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string relativeRecordSetName, Azure.ResourceManager.Dns.DnsTlsaRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsTlsaRecordResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string relativeRecordSetName, Azure.ResourceManager.Dns.DnsTlsaRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string relativeRecordSetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string relativeRecordSetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsTlsaRecordResource> Get(string relativeRecordSetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Dns.DnsTlsaRecordResource> GetAll(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Dns.DnsTlsaRecordResource> GetAllAsync(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsTlsaRecordResource>> GetAsync(string relativeRecordSetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Dns.DnsTlsaRecordResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsTlsaRecordResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Dns.DnsTlsaRecordResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsTlsaRecordResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DnsTlsaRecordData : Azure.ResourceManager.Dns.DnsBaseRecordData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsTlsaRecordData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsTlsaRecordData>
    {
        public DnsTlsaRecordData() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsTlsaRecordInfo> DnsTlsaRecords { get { throw null; } }
        Azure.ResourceManager.Dns.DnsTlsaRecordData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsTlsaRecordData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsTlsaRecordData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.DnsTlsaRecordData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsTlsaRecordData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsTlsaRecordData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsTlsaRecordData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsTlsaRecordResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DnsTlsaRecordResource() { }
        public virtual Azure.ResourceManager.Dns.DnsTlsaRecordData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string zoneName, string relativeRecordSetName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsTlsaRecordResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsTlsaRecordResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsTlsaRecordResource> Update(Azure.ResourceManager.Dns.DnsTlsaRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsTlsaRecordResource>> UpdateAsync(Azure.ResourceManager.Dns.DnsTlsaRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DnsTxtRecordCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsTxtRecordResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsTxtRecordResource>, System.Collections.IEnumerable
    {
        protected DnsTxtRecordCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsTxtRecordResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string txtRecordName, Azure.ResourceManager.Dns.DnsTxtRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsTxtRecordResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string txtRecordName, Azure.ResourceManager.Dns.DnsTxtRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string txtRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string txtRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsTxtRecordResource> Get(string txtRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Dns.DnsTxtRecordResource> GetAll(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Dns.DnsTxtRecordResource> GetAllAsync(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsTxtRecordResource>> GetAsync(string txtRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Dns.DnsTxtRecordResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsTxtRecordResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Dns.DnsTxtRecordResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsTxtRecordResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DnsTxtRecordData : Azure.ResourceManager.Dns.DnsBaseRecordData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsTxtRecordData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsTxtRecordData>
    {
        public DnsTxtRecordData() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsTxtRecordInfo> DnsTxtRecords { get { throw null; } }
        Azure.ResourceManager.Dns.DnsTxtRecordData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsTxtRecordData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsTxtRecordData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.DnsTxtRecordData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsTxtRecordData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsTxtRecordData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsTxtRecordData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsTxtRecordResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DnsTxtRecordResource() { }
        public virtual Azure.ResourceManager.Dns.DnsTxtRecordData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string zoneName, string txtRecordName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsTxtRecordResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsTxtRecordResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsTxtRecordResource> Update(Azure.ResourceManager.Dns.DnsTxtRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsTxtRecordResource>> UpdateAsync(Azure.ResourceManager.Dns.DnsTxtRecordData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DnsZoneCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsZoneResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsZoneResource>, System.Collections.IEnumerable
    {
        protected DnsZoneCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsZoneResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string zoneName, Azure.ResourceManager.Dns.DnsZoneData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Dns.DnsZoneResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string zoneName, Azure.ResourceManager.Dns.DnsZoneData data, Azure.ETag? ifMatch = default(Azure.ETag?), string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string zoneName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string zoneName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsZoneResource> Get(string zoneName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Dns.DnsZoneResource> GetAll(int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Dns.DnsZoneResource> GetAllAsync(int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsZoneResource>> GetAsync(string zoneName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Dns.DnsZoneResource> GetIfExists(string zoneName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Dns.DnsZoneResource>> GetIfExistsAsync(string zoneName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Dns.DnsZoneResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Dns.DnsZoneResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Dns.DnsZoneResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.DnsZoneResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DnsZoneData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsZoneData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsZoneData>
    {
        public DnsZoneData(Azure.Core.AzureLocation location) { }
        public Azure.ETag? ETag { get { throw null; } set { } }
        public long? MaxNumberOfRecords { get { throw null; } }
        public long? MaxNumberOfRecordsPerRecord { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> NameServers { get { throw null; } }
        public long? NumberOfRecords { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.WritableSubResource> RegistrationVirtualNetworks { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.WritableSubResource> ResolutionVirtualNetworks { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Dns.Models.DnsSigningKey> SigningKeys { get { throw null; } }
        public Azure.ResourceManager.Dns.Models.DnsZoneType? ZoneType { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.DnsZoneData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsZoneData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.DnsZoneData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.DnsZoneData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsZoneData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsZoneData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.DnsZoneData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsZoneResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DnsZoneResource() { }
        public virtual Azure.ResourceManager.Dns.DnsZoneData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsZoneResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsZoneResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string zoneName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsZoneResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Dns.DnsRecordData> GetAllRecordData(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Dns.DnsRecordData> GetAllRecordDataAsync(int? top = default(int?), string recordsetnamesuffix = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsZoneResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsAaaaRecordResource> GetDnsAaaaRecord(string aaaaRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsAaaaRecordResource>> GetDnsAaaaRecordAsync(string aaaaRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsAaaaRecordCollection GetDnsAaaaRecords() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsARecordResource> GetDnsARecord(string aRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsARecordResource>> GetDnsARecordAsync(string aRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsARecordCollection GetDnsARecords() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsCaaRecordResource> GetDnsCaaRecord(string caaRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsCaaRecordResource>> GetDnsCaaRecordAsync(string caaRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsCaaRecordCollection GetDnsCaaRecords() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsCnameRecordResource> GetDnsCnameRecord(string cnameRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsCnameRecordResource>> GetDnsCnameRecordAsync(string cnameRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsCnameRecordCollection GetDnsCnameRecords() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsDSRecordResource> GetDnsDSRecord(string dsRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsDSRecordResource>> GetDnsDSRecordAsync(string dsRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsDSRecordCollection GetDnsDSRecords() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsMXRecordResource> GetDnsMXRecord(string mxRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsMXRecordResource>> GetDnsMXRecordAsync(string mxRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsMXRecordCollection GetDnsMXRecords() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsNaptrRecordResource> GetDnsNaptrRecord(string naptrRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsNaptrRecordResource>> GetDnsNaptrRecordAsync(string naptrRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsNaptrRecordCollection GetDnsNaptrRecords() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsNSRecordResource> GetDnsNSRecord(string nsRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsNSRecordResource>> GetDnsNSRecordAsync(string nsRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsNSRecordCollection GetDnsNSRecords() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsPtrRecordResource> GetDnsPtrRecord(string ptrRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsPtrRecordResource>> GetDnsPtrRecordAsync(string ptrRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsPtrRecordCollection GetDnsPtrRecords() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsSoaRecordResource> GetDnsSoaRecord(string soaRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsSoaRecordResource>> GetDnsSoaRecordAsync(string soaRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsSoaRecordCollection GetDnsSoaRecords() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsSrvRecordResource> GetDnsSrvRecord(string srvRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsSrvRecordResource>> GetDnsSrvRecordAsync(string srvRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsSrvRecordCollection GetDnsSrvRecords() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsTlsaRecordResource> GetDnsTlsaRecord(string tlsaRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsTlsaRecordResource>> GetDnsTlsaRecordAsync(string tlsaRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsTlsaRecordCollection GetDnsTlsaRecords() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsTxtRecordResource> GetDnsTxtRecord(string txtRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsTxtRecordResource>> GetDnsTxtRecordAsync(string txtRecordName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsTxtRecordCollection GetDnsTxtRecords() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsZoneResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsZoneResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsZoneResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsZoneResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsZoneResource> Update(Azure.ResourceManager.Dns.Models.DnsZonePatch patch, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsZoneResource>> UpdateAsync(Azure.ResourceManager.Dns.Models.DnsZonePatch patch, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Dns.Mocking
{
    public partial class MockableDnsArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableDnsArmClient() { }
        public virtual Azure.ResourceManager.Dns.DnsAaaaRecordResource GetDnsAaaaRecordResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsARecordResource GetDnsARecordResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsCaaRecordResource GetDnsCaaRecordResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsCnameRecordResource GetDnsCnameRecordResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsDSRecordResource GetDnsDSRecordResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsMXRecordResource GetDnsMXRecordResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsNaptrRecordResource GetDnsNaptrRecordResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsNSRecordResource GetDnsNSRecordResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsPtrRecordResource GetDnsPtrRecordResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnssecConfigResource GetDnssecConfigResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsSoaRecordResource GetDnsSoaRecordResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsSrvRecordResource GetDnsSrvRecordResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsTlsaRecordResource GetDnsTlsaRecordResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsTxtRecordResource GetDnsTxtRecordResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsZoneResource GetDnsZoneResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableDnsResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableDnsResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.Dns.DnsZoneResource> GetDnsZone(string zoneName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.DnsZoneResource>> GetDnsZoneAsync(string zoneName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Dns.DnsZoneCollection GetDnsZones() { throw null; }
    }
    public partial class MockableDnsSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableDnsSubscriptionResource() { }
        public virtual Azure.Response<Azure.ResourceManager.Dns.Models.DnsResourceReferenceResult> GetDnsResourceReferencesByTargetResources(Azure.ResourceManager.Dns.Models.DnsResourceReferenceContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Dns.Models.DnsResourceReferenceResult>> GetDnsResourceReferencesByTargetResourcesAsync(Azure.ResourceManager.Dns.Models.DnsResourceReferenceContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Dns.DnsZoneResource> GetDnsZones(int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Dns.DnsZoneResource> GetDnsZonesAsync(int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Dns.Models
{
    public static partial class ArmDnsModelFactory
    {
        public static Azure.ResourceManager.Dns.Models.DelegationSignerInfo DelegationSignerInfo(int? digestAlgorithmType = default(int?), string digestValue = null, string record = null) { throw null; }
        public static Azure.ResourceManager.Dns.DnsAaaaRecordData DnsAaaaRecordData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ETag? etag = default(Azure.ETag?), System.Collections.Generic.IDictionary<string, string> metadata = null, long? ttl = default(long?), string fqdn = null, string provisioningState = null, Azure.ResourceManager.Resources.Models.WritableSubResource targetResource = null, System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsAaaaRecordInfo> aaaaRecords = null) { throw null; }
        public static Azure.ResourceManager.Dns.DnsARecordData DnsARecordData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ETag? etag = default(Azure.ETag?), System.Collections.Generic.IDictionary<string, string> metadata = null, long? ttl = default(long?), string fqdn = null, string provisioningState = null, Azure.ResourceManager.Resources.Models.WritableSubResource targetResource = null, System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsARecordInfo> aRecords = null) { throw null; }
        public static Azure.ResourceManager.Dns.DnsCaaRecordData DnsCaaRecordData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ETag? etag = default(Azure.ETag?), System.Collections.Generic.IDictionary<string, string> metadata = null, long? ttl = default(long?), string fqdn = null, string provisioningState = null, Azure.ResourceManager.Resources.Models.WritableSubResource targetResource = null, System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsCaaRecordInfo> caaRecords = null) { throw null; }
        public static Azure.ResourceManager.Dns.DnsCnameRecordData DnsCnameRecordData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ETag? etag = default(Azure.ETag?), System.Collections.Generic.IDictionary<string, string> metadata = null, long? ttl = default(long?), string fqdn = null, string provisioningState = null, Azure.ResourceManager.Resources.Models.WritableSubResource targetResource = null, string CnameRecordName = null) { throw null; }
        public static Azure.ResourceManager.Dns.DnsMXRecordData DnsMXRecordData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ETag? etag = default(Azure.ETag?), System.Collections.Generic.IDictionary<string, string> metadata = null, long? ttl = default(long?), string fqdn = null, string provisioningState = null, Azure.ResourceManager.Resources.Models.WritableSubResource targetResource = null, System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsMXRecordInfo> mxRecords = null) { throw null; }
        public static Azure.ResourceManager.Dns.DnsNSRecordData DnsNSRecordData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ETag? etag = default(Azure.ETag?), System.Collections.Generic.IDictionary<string, string> metadata = null, long? ttl = default(long?), string fqdn = null, string provisioningState = null, Azure.ResourceManager.Resources.Models.WritableSubResource targetResource = null, System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsNSRecordInfo> nsRecords = null) { throw null; }
        public static Azure.ResourceManager.Dns.DnsPtrRecordData DnsPtrRecordData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ETag? etag = default(Azure.ETag?), System.Collections.Generic.IDictionary<string, string> metadata = null, long? ttl = default(long?), string fqdn = null, string provisioningState = null, Azure.ResourceManager.Resources.Models.WritableSubResource targetResource = null, System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsPtrRecordInfo> ptrRecords = null) { throw null; }
        public static Azure.ResourceManager.Dns.DnsRecordData DnsRecordData(Azure.Core.ResourceIdentifier id, string name, Azure.Core.ResourceType resourceType, Azure.ResourceManager.Models.SystemData systemData, Azure.ETag? etag, System.Collections.Generic.IDictionary<string, string> metadata, long? ttl, string fqdn, string provisioningState, Azure.ResourceManager.Resources.Models.WritableSubResource targetResource, Azure.ResourceManager.Resources.Models.WritableSubResource trafficManagementProfile, System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsARecordInfo> aRecords, System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsAaaaRecordInfo> aaaaRecords, System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsMXRecordInfo> mxRecords, System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsNSRecordInfo> nsRecords, System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsPtrRecordInfo> ptrRecords, System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsSrvRecordInfo> srvRecords, System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsTxtRecordInfo> txtRecords, string cname, Azure.ResourceManager.Dns.Models.DnsSoaRecordInfo soaRecordInfo, System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsCaaRecordInfo> caaRecords, System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsDSRecordInfo> dsRecords, System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsTlsaRecordInfo> tlsaRecords, System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsNaptrRecordInfo> naptrRecords, System.Collections.Generic.IDictionary<string, System.BinaryData> serializedAdditionalRawData) { throw null; }
        public static Azure.ResourceManager.Dns.Models.DnsResourceReference DnsResourceReference(System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.WritableSubResource> dnsResources = null, Azure.Core.ResourceIdentifier targetResourceId = null) { throw null; }
        public static Azure.ResourceManager.Dns.Models.DnsResourceReferenceResult DnsResourceReferenceResult(System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.Models.DnsResourceReference> dnsResourceReferences = null) { throw null; }
        public static Azure.ResourceManager.Dns.DnssecConfigData DnssecConfigData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ETag? etag = default(Azure.ETag?), string provisioningState = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.Models.DnsSigningKey> signingKeys = null) { throw null; }
        public static Azure.ResourceManager.Dns.Models.DnsSigningKey DnsSigningKey(System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.Models.DelegationSignerInfo> delegationSignerInfo = null, int? flags = default(int?), int? keyTag = default(int?), int? protocol = default(int?), string publicKey = null, int? securityAlgorithmType = default(int?)) { throw null; }
        public static Azure.ResourceManager.Dns.DnsSoaRecordData DnsSoaRecordData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ETag? etag = default(Azure.ETag?), System.Collections.Generic.IDictionary<string, string> metadata = null, long? ttl = default(long?), string fqdn = null, string provisioningState = null, Azure.ResourceManager.Resources.Models.WritableSubResource targetResource = null, Azure.ResourceManager.Dns.Models.DnsSoaRecordInfo soaRecords = null) { throw null; }
        public static Azure.ResourceManager.Dns.DnsSrvRecordData DnsSrvRecordData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ETag? etag = default(Azure.ETag?), System.Collections.Generic.IDictionary<string, string> metadata = null, long? ttl = default(long?), string fqdn = null, string provisioningState = null, Azure.ResourceManager.Resources.Models.WritableSubResource targetResource = null, System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsSrvRecordInfo> srvRecords = null) { throw null; }
        public static Azure.ResourceManager.Dns.DnsTxtRecordData DnsTxtRecordData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ETag? etag = default(Azure.ETag?), System.Collections.Generic.IDictionary<string, string> metadata = null, long? ttl = default(long?), string fqdn = null, string provisioningState = null, Azure.ResourceManager.Resources.Models.WritableSubResource targetResource = null, System.Collections.Generic.IList<Azure.ResourceManager.Dns.Models.DnsTxtRecordInfo> txtRecords = null) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static Azure.ResourceManager.Dns.DnsZoneData DnsZoneData(Azure.Core.ResourceIdentifier id, string name, Azure.Core.ResourceType resourceType, Azure.ResourceManager.Models.SystemData systemData, System.Collections.Generic.IDictionary<string, string> tags, Azure.Core.AzureLocation location, Azure.ETag? etag, long? maxNumberOfRecords, long? maxNumberOfRecordsPerRecord, long? numberOfRecords, System.Collections.Generic.IEnumerable<string> nameServers, Azure.ResourceManager.Dns.Models.DnsZoneType? zoneType, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.WritableSubResource> registrationVirtualNetworks, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.WritableSubResource> resolutionVirtualNetworks) { throw null; }
        public static Azure.ResourceManager.Dns.DnsZoneData DnsZoneData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ETag? etag = default(Azure.ETag?), long? maxNumberOfRecords = default(long?), long? maxNumberOfRecordsPerRecord = default(long?), long? numberOfRecords = default(long?), System.Collections.Generic.IEnumerable<string> nameServers = null, Azure.ResourceManager.Dns.Models.DnsZoneType? zoneType = default(Azure.ResourceManager.Dns.Models.DnsZoneType?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.WritableSubResource> registrationVirtualNetworks = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.WritableSubResource> resolutionVirtualNetworks = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Dns.Models.DnsSigningKey> signingKeys = null) { throw null; }
    }
    public partial class DelegationSignerInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DelegationSignerInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DelegationSignerInfo>
    {
        internal DelegationSignerInfo() { }
        public int? DigestAlgorithmType { get { throw null; } }
        public string DigestValue { get { throw null; } }
        public string Record { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DelegationSignerInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DelegationSignerInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DelegationSignerInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DelegationSignerInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DelegationSignerInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DelegationSignerInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DelegationSignerInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsAaaaRecordInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsAaaaRecordInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsAaaaRecordInfo>
    {
        public DnsAaaaRecordInfo() { }
        public System.Net.IPAddress IPv6Address { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsAaaaRecordInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsAaaaRecordInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsAaaaRecordInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsAaaaRecordInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsAaaaRecordInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsAaaaRecordInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsAaaaRecordInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsARecordInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsARecordInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsARecordInfo>
    {
        public DnsARecordInfo() { }
        public System.Net.IPAddress IPv4Address { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsARecordInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsARecordInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsARecordInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsARecordInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsARecordInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsARecordInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsARecordInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsCaaRecordInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsCaaRecordInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsCaaRecordInfo>
    {
        public DnsCaaRecordInfo() { }
        public int? Flags { get { throw null; } set { } }
        public string Tag { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsCaaRecordInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsCaaRecordInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsCaaRecordInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsCaaRecordInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsCaaRecordInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsCaaRecordInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsCaaRecordInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsDSRecordInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsDSRecordInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsDSRecordInfo>
    {
        public DnsDSRecordInfo() { }
        public int? Algorithm { get { throw null; } set { } }
        public Azure.ResourceManager.Dns.Models.DSRecordDigest Digest { get { throw null; } set { } }
        public int? KeyTag { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsDSRecordInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsDSRecordInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsDSRecordInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsDSRecordInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsDSRecordInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsDSRecordInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsDSRecordInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsMXRecordInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsMXRecordInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsMXRecordInfo>
    {
        public DnsMXRecordInfo() { }
        public string Exchange { get { throw null; } set { } }
        public int? Preference { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsMXRecordInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsMXRecordInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsMXRecordInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsMXRecordInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsMXRecordInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsMXRecordInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsMXRecordInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsNaptrRecordInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsNaptrRecordInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsNaptrRecordInfo>
    {
        public DnsNaptrRecordInfo() { }
        public string Flags { get { throw null; } set { } }
        public int? Order { get { throw null; } set { } }
        public int? Preference { get { throw null; } set { } }
        public string Regexp { get { throw null; } set { } }
        public string Replacement { get { throw null; } set { } }
        public string Services { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsNaptrRecordInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsNaptrRecordInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsNaptrRecordInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsNaptrRecordInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsNaptrRecordInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsNaptrRecordInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsNaptrRecordInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsNSRecordInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsNSRecordInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsNSRecordInfo>
    {
        public DnsNSRecordInfo() { }
        public string DnsNSDomainName { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsNSRecordInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsNSRecordInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsNSRecordInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsNSRecordInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsNSRecordInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsNSRecordInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsNSRecordInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsPtrRecordInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsPtrRecordInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsPtrRecordInfo>
    {
        public DnsPtrRecordInfo() { }
        public string DnsPtrDomainName { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsPtrRecordInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsPtrRecordInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsPtrRecordInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsPtrRecordInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsPtrRecordInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsPtrRecordInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsPtrRecordInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public enum DnsRecordType
    {
        A = 0,
        Aaaa = 1,
        CAA = 2,
        Cname = 3,
        MX = 4,
        NS = 5,
        PTR = 6,
        SOA = 7,
        SRV = 8,
        TXT = 9,
        Tlsa = 10,
        DS = 11,
        Naptr = 12,
    }
    public partial class DnsResourceReference : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsResourceReference>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsResourceReference>
    {
        internal DnsResourceReference() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.WritableSubResource> DnsResources { get { throw null; } }
        public Azure.Core.ResourceIdentifier TargetResourceId { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsResourceReference System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsResourceReference>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsResourceReference>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsResourceReference System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsResourceReference>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsResourceReference>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsResourceReference>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsResourceReferenceContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsResourceReferenceContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsResourceReferenceContent>
    {
        public DnsResourceReferenceContent() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.WritableSubResource> TargetResources { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsResourceReferenceContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsResourceReferenceContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsResourceReferenceContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsResourceReferenceContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsResourceReferenceContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsResourceReferenceContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsResourceReferenceContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsResourceReferenceResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsResourceReferenceResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsResourceReferenceResult>
    {
        internal DnsResourceReferenceResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Dns.Models.DnsResourceReference> DnsResourceReferences { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsResourceReferenceResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsResourceReferenceResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsResourceReferenceResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsResourceReferenceResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsResourceReferenceResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsResourceReferenceResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsResourceReferenceResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsSigningKey : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsSigningKey>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsSigningKey>
    {
        internal DnsSigningKey() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Dns.Models.DelegationSignerInfo> DelegationSignerInfo { get { throw null; } }
        public int? Flags { get { throw null; } }
        public int? KeyTag { get { throw null; } }
        public int? Protocol { get { throw null; } }
        public string PublicKey { get { throw null; } }
        public int? SecurityAlgorithmType { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsSigningKey System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsSigningKey>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsSigningKey>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsSigningKey System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsSigningKey>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsSigningKey>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsSigningKey>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsSoaRecordInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsSoaRecordInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsSoaRecordInfo>
    {
        public DnsSoaRecordInfo() { }
        public string Email { get { throw null; } set { } }
        public long? ExpireTimeInSeconds { get { throw null; } set { } }
        public string Host { get { throw null; } set { } }
        public long? MinimumTtlInSeconds { get { throw null; } set { } }
        public long? RefreshTimeInSeconds { get { throw null; } set { } }
        public long? RetryTimeInSeconds { get { throw null; } set { } }
        public long? SerialNumber { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsSoaRecordInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsSoaRecordInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsSoaRecordInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsSoaRecordInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsSoaRecordInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsSoaRecordInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsSoaRecordInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsSrvRecordInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsSrvRecordInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsSrvRecordInfo>
    {
        public DnsSrvRecordInfo() { }
        public int? Port { get { throw null; } set { } }
        public int? Priority { get { throw null; } set { } }
        public string Target { get { throw null; } set { } }
        public int? Weight { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsSrvRecordInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsSrvRecordInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsSrvRecordInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsSrvRecordInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsSrvRecordInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsSrvRecordInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsSrvRecordInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsTlsaRecordInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsTlsaRecordInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsTlsaRecordInfo>
    {
        public DnsTlsaRecordInfo() { }
        public string CertAssociationData { get { throw null; } set { } }
        public int? MatchingType { get { throw null; } set { } }
        public int? Selector { get { throw null; } set { } }
        public int? Usage { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsTlsaRecordInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsTlsaRecordInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsTlsaRecordInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsTlsaRecordInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsTlsaRecordInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsTlsaRecordInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsTlsaRecordInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsTxtRecordInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsTxtRecordInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsTxtRecordInfo>
    {
        public DnsTxtRecordInfo() { }
        public System.Collections.Generic.IList<string> Values { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsTxtRecordInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsTxtRecordInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsTxtRecordInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsTxtRecordInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsTxtRecordInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsTxtRecordInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsTxtRecordInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DnsZonePatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsZonePatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsZonePatch>
    {
        public DnsZonePatch() { }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsZonePatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsZonePatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DnsZonePatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DnsZonePatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsZonePatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsZonePatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DnsZonePatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public enum DnsZoneType
    {
        Public = 0,
        Private = 1,
    }
    public partial class DSRecordDigest : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DSRecordDigest>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DSRecordDigest>
    {
        public DSRecordDigest() { }
        public int? AlgorithmType { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DSRecordDigest System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DSRecordDigest>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Dns.Models.DSRecordDigest>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Dns.Models.DSRecordDigest System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DSRecordDigest>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DSRecordDigest>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Dns.Models.DSRecordDigest>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
