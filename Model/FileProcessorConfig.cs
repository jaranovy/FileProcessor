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

        private FileProcessorConfigTask[] taskField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Task")]
        public FileProcessorConfigTask[] Task
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

        private FileProcessorConfigTaskAction[] actionsField;

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
        [System.Xml.Serialization.XmlArrayItemAttribute("Action", IsNullable = false)]
        public FileProcessorConfigTaskAction[] Actions
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

        private string[] fileField;

        private string[] fileMaskField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("File")]
        public string[] File
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
        [System.Xml.Serialization.XmlElementAttribute("FileMask")]
        public string[] FileMask
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
    public partial class FileProcessorConfigTaskAction
    {

        private string typeField;

        private string tableNameField;

        private string queryField;

        private string destinationField;

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

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
