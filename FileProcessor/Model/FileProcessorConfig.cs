using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessor.Model
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://novych.cz/schemas/Schemas/FileProcessorConfig")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://novych.cz/schemas/Schemas/FileProcessorConfig", IsNullable = false)]
    public partial class FileProcessorConfig
    {

        private FileProcessorConfigTask taskField;

        /// <remarks/>
        public FileProcessorConfigTask Task
        {
            get
            {
                return this.taskField;
            }
            set
            {
                this.taskField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://novych.cz/schemas/Schemas/FileProcessorConfig")]
    public partial class FileProcessorConfigTask
    {

        private FileProcessorConfigTaskFiles filesField;

        private FileProcessorConfigTaskActions actionsField;

        /// <remarks/>
        public FileProcessorConfigTaskFiles Files
        {
            get
            {
                return this.filesField;
            }
            set
            {
                this.filesField = value;
            }
        }

        /// <remarks/>
        public FileProcessorConfigTaskActions Actions
        {
            get
            {
                return this.actionsField;
            }
            set
            {
                this.actionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://novych.cz/schemas/Schemas/FileProcessorConfig")]
    public partial class FileProcessorConfigTaskFiles
    {

        private string fileField;

        private string fileMaskField;

        /// <remarks/>
        public string File
        {
            get
            {
                return this.fileField;
            }
            set
            {
                this.fileField = value;
            }
        }

        /// <remarks/>
        public string FileMask
        {
            get
            {
                return this.fileMaskField;
            }
            set
            {
                this.fileMaskField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://novych.cz/schemas/Schemas/FileProcessorConfig")]
    public partial class FileProcessorConfigTaskActions
    {

        private FileProcessorConfigTaskActionsArchive archiveField;

        private FileProcessorConfigTaskActionsLoadFile loadFileField;

        private FileProcessorConfigTaskActionsProcessRecord processRecordField;

        private FileProcessorConfigTaskActionsExport exportField;

        /// <remarks/>
        public FileProcessorConfigTaskActionsArchive Archive
        {
            get
            {
                return this.archiveField;
            }
            set
            {
                this.archiveField = value;
            }
        }

        /// <remarks/>
        public FileProcessorConfigTaskActionsLoadFile LoadFile
        {
            get
            {
                return this.loadFileField;
            }
            set
            {
                this.loadFileField = value;
            }
        }

        /// <remarks/>
        public FileProcessorConfigTaskActionsProcessRecord ProcessRecord
        {
            get
            {
                return this.processRecordField;
            }
            set
            {
                this.processRecordField = value;
            }
        }

        /// <remarks/>
        public FileProcessorConfigTaskActionsExport Export
        {
            get
            {
                return this.exportField;
            }
            set
            {
                this.exportField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://novych.cz/schemas/Schemas/FileProcessorConfig")]
    public partial class FileProcessorConfigTaskActionsArchive
    {

        private string destinationField;

        /// <remarks/>
        public string Destination
        {
            get
            {
                return this.destinationField;
            }
            set
            {
                this.destinationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://novych.cz/schemas/Schemas/FileProcessorConfig")]
    public partial class FileProcessorConfigTaskActionsLoadFile
    {

        private string tableNameField;

        private string queryField;

        /// <remarks/>
        public string TableName
        {
            get
            {
                return this.tableNameField;
            }
            set
            {
                this.tableNameField = value;
            }
        }

        /// <remarks/>
        public string Query
        {
            get
            {
                return this.queryField;
            }
            set
            {
                this.queryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://novych.cz/schemas/Schemas/FileProcessorConfig")]
    public partial class FileProcessorConfigTaskActionsProcessRecord
    {

        private string queryField;

        /// <remarks/>
        public string Query
        {
            get
            {
                return this.queryField;
            }
            set
            {
                this.queryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://novych.cz/schemas/Schemas/FileProcessorConfig")]
    public partial class FileProcessorConfigTaskActionsExport
    {

        private string queryField;

        private string destinationField;

        /// <remarks/>
        public string Query
        {
            get
            {
                return this.queryField;
            }
            set
            {
                this.queryField = value;
            }
        }

        /// <remarks/>
        public string Destination
        {
            get
            {
                return this.destinationField;
            }
            set
            {
                this.destinationField = value;
            }
        }
    }


}
