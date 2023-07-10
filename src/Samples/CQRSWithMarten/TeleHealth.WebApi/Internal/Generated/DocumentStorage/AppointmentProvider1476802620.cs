// <auto-generated/>
#pragma warning disable
using Marten.Internal;
using Marten.Internal.Storage;
using Marten.Schema;
using Marten.Schema.Arguments;
using Npgsql;
using System;
using System.Collections.Generic;
using TeleHealth.Common;
using Weasel.Core;
using Weasel.Postgresql;

namespace Marten.Generated.DocumentStorage
{
    // START: UpsertAppointmentOperation1476802620
    public class UpsertAppointmentOperation1476802620 : Marten.Internal.Operations.StorageOperation<TeleHealth.Common.Appointment, System.Guid>
    {
        private readonly TeleHealth.Common.Appointment _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpsertAppointmentOperation1476802620(TeleHealth.Common.Appointment document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_upsert_appointment(?, ?, ?, ?)";


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Upsert;
        }


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, TeleHealth.Common.Appointment document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }

    }

    // END: UpsertAppointmentOperation1476802620
    
    
    // START: InsertAppointmentOperation1476802620
    public class InsertAppointmentOperation1476802620 : Marten.Internal.Operations.StorageOperation<TeleHealth.Common.Appointment, System.Guid>
    {
        private readonly TeleHealth.Common.Appointment _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InsertAppointmentOperation1476802620(TeleHealth.Common.Appointment document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_insert_appointment(?, ?, ?, ?)";


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Insert;
        }


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, TeleHealth.Common.Appointment document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }

    }

    // END: InsertAppointmentOperation1476802620
    
    
    // START: UpdateAppointmentOperation1476802620
    public class UpdateAppointmentOperation1476802620 : Marten.Internal.Operations.StorageOperation<TeleHealth.Common.Appointment, System.Guid>
    {
        private readonly TeleHealth.Common.Appointment _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpdateAppointmentOperation1476802620(TeleHealth.Common.Appointment document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_update_appointment(?, ?, ?, ?)";


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
            postprocessUpdate(reader, exceptions);
        }


        public override async System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            await postprocessUpdateAsync(reader, exceptions, token);
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Update;
        }


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, TeleHealth.Common.Appointment document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }

    }

    // END: UpdateAppointmentOperation1476802620
    
    
    // START: QueryOnlyAppointmentSelector1476802620
    public class QueryOnlyAppointmentSelector1476802620 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<TeleHealth.Common.Appointment>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public QueryOnlyAppointmentSelector1476802620(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public TeleHealth.Common.Appointment Resolve(System.Data.Common.DbDataReader reader)
        {

            TeleHealth.Common.Appointment document;
            document = _serializer.FromJson<TeleHealth.Common.Appointment>(reader, 0);
            return document;
        }


        public async System.Threading.Tasks.Task<TeleHealth.Common.Appointment> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {

            TeleHealth.Common.Appointment document;
            document = await _serializer.FromJsonAsync<TeleHealth.Common.Appointment>(reader, 0, token).ConfigureAwait(false);
            return document;
        }

    }

    // END: QueryOnlyAppointmentSelector1476802620
    
    
    // START: LightweightAppointmentSelector1476802620
    public class LightweightAppointmentSelector1476802620 : Marten.Internal.CodeGeneration.DocumentSelectorWithVersions<TeleHealth.Common.Appointment, System.Guid>, Marten.Linq.Selectors.ISelector<TeleHealth.Common.Appointment>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public LightweightAppointmentSelector1476802620(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public TeleHealth.Common.Appointment Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);

            TeleHealth.Common.Appointment document;
            document = _serializer.FromJson<TeleHealth.Common.Appointment>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }


        public async System.Threading.Tasks.Task<TeleHealth.Common.Appointment> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);

            TeleHealth.Common.Appointment document;
            document = await _serializer.FromJsonAsync<TeleHealth.Common.Appointment>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }

    }

    // END: LightweightAppointmentSelector1476802620
    
    
    // START: IdentityMapAppointmentSelector1476802620
    public class IdentityMapAppointmentSelector1476802620 : Marten.Internal.CodeGeneration.DocumentSelectorWithIdentityMap<TeleHealth.Common.Appointment, System.Guid>, Marten.Linq.Selectors.ISelector<TeleHealth.Common.Appointment>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public IdentityMapAppointmentSelector1476802620(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public TeleHealth.Common.Appointment Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            TeleHealth.Common.Appointment document;
            document = _serializer.FromJson<TeleHealth.Common.Appointment>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }


        public async System.Threading.Tasks.Task<TeleHealth.Common.Appointment> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            TeleHealth.Common.Appointment document;
            document = await _serializer.FromJsonAsync<TeleHealth.Common.Appointment>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }

    }

    // END: IdentityMapAppointmentSelector1476802620
    
    
    // START: DirtyTrackingAppointmentSelector1476802620
    public class DirtyTrackingAppointmentSelector1476802620 : Marten.Internal.CodeGeneration.DocumentSelectorWithDirtyChecking<TeleHealth.Common.Appointment, System.Guid>, Marten.Linq.Selectors.ISelector<TeleHealth.Common.Appointment>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DirtyTrackingAppointmentSelector1476802620(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public TeleHealth.Common.Appointment Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            TeleHealth.Common.Appointment document;
            document = _serializer.FromJson<TeleHealth.Common.Appointment>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }


        public async System.Threading.Tasks.Task<TeleHealth.Common.Appointment> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            TeleHealth.Common.Appointment document;
            document = await _serializer.FromJsonAsync<TeleHealth.Common.Appointment>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }

    }

    // END: DirtyTrackingAppointmentSelector1476802620
    
    
    // START: QueryOnlyAppointmentDocumentStorage1476802620
    public class QueryOnlyAppointmentDocumentStorage1476802620 : Marten.Internal.Storage.QueryOnlyDocumentStorage<TeleHealth.Common.Appointment, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public QueryOnlyAppointmentDocumentStorage1476802620(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(TeleHealth.Common.Appointment document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(TeleHealth.Common.Appointment document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateAppointmentOperation1476802620
            (
                document, Identity(document),
                session.Versions.ForType<TeleHealth.Common.Appointment, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(TeleHealth.Common.Appointment document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertAppointmentOperation1476802620
            (
                document, Identity(document),
                session.Versions.ForType<TeleHealth.Common.Appointment, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(TeleHealth.Common.Appointment document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertAppointmentOperation1476802620
            (
                document, Identity(document),
                session.Versions.ForType<TeleHealth.Common.Appointment, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(TeleHealth.Common.Appointment document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(TeleHealth.Common.Appointment document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.QueryOnlyAppointmentSelector1476802620(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: QueryOnlyAppointmentDocumentStorage1476802620
    
    
    // START: LightweightAppointmentDocumentStorage1476802620
    public class LightweightAppointmentDocumentStorage1476802620 : Marten.Internal.Storage.LightweightDocumentStorage<TeleHealth.Common.Appointment, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public LightweightAppointmentDocumentStorage1476802620(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(TeleHealth.Common.Appointment document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(TeleHealth.Common.Appointment document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateAppointmentOperation1476802620
            (
                document, Identity(document),
                session.Versions.ForType<TeleHealth.Common.Appointment, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(TeleHealth.Common.Appointment document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertAppointmentOperation1476802620
            (
                document, Identity(document),
                session.Versions.ForType<TeleHealth.Common.Appointment, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(TeleHealth.Common.Appointment document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertAppointmentOperation1476802620
            (
                document, Identity(document),
                session.Versions.ForType<TeleHealth.Common.Appointment, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(TeleHealth.Common.Appointment document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(TeleHealth.Common.Appointment document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.LightweightAppointmentSelector1476802620(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: LightweightAppointmentDocumentStorage1476802620
    
    
    // START: IdentityMapAppointmentDocumentStorage1476802620
    public class IdentityMapAppointmentDocumentStorage1476802620 : Marten.Internal.Storage.IdentityMapDocumentStorage<TeleHealth.Common.Appointment, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public IdentityMapAppointmentDocumentStorage1476802620(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(TeleHealth.Common.Appointment document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(TeleHealth.Common.Appointment document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateAppointmentOperation1476802620
            (
                document, Identity(document),
                session.Versions.ForType<TeleHealth.Common.Appointment, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(TeleHealth.Common.Appointment document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertAppointmentOperation1476802620
            (
                document, Identity(document),
                session.Versions.ForType<TeleHealth.Common.Appointment, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(TeleHealth.Common.Appointment document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertAppointmentOperation1476802620
            (
                document, Identity(document),
                session.Versions.ForType<TeleHealth.Common.Appointment, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(TeleHealth.Common.Appointment document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(TeleHealth.Common.Appointment document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.IdentityMapAppointmentSelector1476802620(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: IdentityMapAppointmentDocumentStorage1476802620
    
    
    // START: DirtyTrackingAppointmentDocumentStorage1476802620
    public class DirtyTrackingAppointmentDocumentStorage1476802620 : Marten.Internal.Storage.DirtyCheckedDocumentStorage<TeleHealth.Common.Appointment, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public DirtyTrackingAppointmentDocumentStorage1476802620(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(TeleHealth.Common.Appointment document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(TeleHealth.Common.Appointment document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateAppointmentOperation1476802620
            (
                document, Identity(document),
                session.Versions.ForType<TeleHealth.Common.Appointment, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(TeleHealth.Common.Appointment document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertAppointmentOperation1476802620
            (
                document, Identity(document),
                session.Versions.ForType<TeleHealth.Common.Appointment, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(TeleHealth.Common.Appointment document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertAppointmentOperation1476802620
            (
                document, Identity(document),
                session.Versions.ForType<TeleHealth.Common.Appointment, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(TeleHealth.Common.Appointment document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(TeleHealth.Common.Appointment document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.DirtyTrackingAppointmentSelector1476802620(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: DirtyTrackingAppointmentDocumentStorage1476802620
    
    
    // START: AppointmentBulkLoader1476802620
    public class AppointmentBulkLoader1476802620 : Marten.Internal.CodeGeneration.BulkLoader<TeleHealth.Common.Appointment, System.Guid>
    {
        private readonly Marten.Internal.Storage.IDocumentStorage<TeleHealth.Common.Appointment, System.Guid> _storage;

        public AppointmentBulkLoader1476802620(Marten.Internal.Storage.IDocumentStorage<TeleHealth.Common.Appointment, System.Guid> storage) : base(storage)
        {
            _storage = storage;
        }


        public const string MAIN_LOADER_SQL = "COPY public.mt_doc_appointment(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string TEMP_LOADER_SQL = "COPY mt_doc_appointment_temp(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string COPY_NEW_DOCUMENTS_SQL = "insert into public.mt_doc_appointment (\"id\", \"data\", \"mt_version\", \"mt_dotnet_type\", mt_last_modified) (select mt_doc_appointment_temp.\"id\", mt_doc_appointment_temp.\"data\", mt_doc_appointment_temp.\"mt_version\", mt_doc_appointment_temp.\"mt_dotnet_type\", transaction_timestamp() from mt_doc_appointment_temp left join public.mt_doc_appointment on mt_doc_appointment_temp.id = public.mt_doc_appointment.id where public.mt_doc_appointment.id is null)";

        public const string OVERWRITE_SQL = "update public.mt_doc_appointment target SET data = source.data, mt_version = source.mt_version, mt_dotnet_type = source.mt_dotnet_type, mt_last_modified = transaction_timestamp() FROM mt_doc_appointment_temp source WHERE source.id = target.id";

        public const string CREATE_TEMP_TABLE_FOR_COPYING_SQL = "create temporary table mt_doc_appointment_temp as select * from public.mt_doc_appointment limit 0";


        public override string CreateTempTableForCopying()
        {
            return CREATE_TEMP_TABLE_FOR_COPYING_SQL;
        }


        public override string CopyNewDocumentsFromTempTable()
        {
            return COPY_NEW_DOCUMENTS_SQL;
        }


        public override string OverwriteDuplicatesFromTempTable()
        {
            return OVERWRITE_SQL;
        }


        public override void LoadRow(Npgsql.NpgsqlBinaryImporter writer, TeleHealth.Common.Appointment document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer)
        {
            writer.Write(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar);
            writer.Write(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb);
        }


        public override async System.Threading.Tasks.Task LoadRowAsync(Npgsql.NpgsqlBinaryImporter writer, TeleHealth.Common.Appointment document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer, System.Threading.CancellationToken cancellation)
        {
            await writer.WriteAsync(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar, cancellation);
            await writer.WriteAsync(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb, cancellation);
        }


        public override string MainLoaderSql()
        {
            return MAIN_LOADER_SQL;
        }


        public override string TempLoaderSql()
        {
            return TEMP_LOADER_SQL;
        }

    }

    // END: AppointmentBulkLoader1476802620
    
    
    // START: AppointmentProvider1476802620
    public class AppointmentProvider1476802620 : Marten.Internal.Storage.DocumentProvider<TeleHealth.Common.Appointment>
    {
        private readonly Marten.Schema.DocumentMapping _mapping;

        public AppointmentProvider1476802620(Marten.Schema.DocumentMapping mapping) : base(new AppointmentBulkLoader1476802620(new QueryOnlyAppointmentDocumentStorage1476802620(mapping)), new QueryOnlyAppointmentDocumentStorage1476802620(mapping), new LightweightAppointmentDocumentStorage1476802620(mapping), new IdentityMapAppointmentDocumentStorage1476802620(mapping), new DirtyTrackingAppointmentDocumentStorage1476802620(mapping))
        {
            _mapping = mapping;
        }


    }

    // END: AppointmentProvider1476802620
    
    
}

