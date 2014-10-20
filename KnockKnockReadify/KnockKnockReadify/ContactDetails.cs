using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace KnockKnockReadify
{
    [DebuggerStepThroughAttribute]
    [GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [DataContractAttribute(Name = "ContactDetails", Namespace = "http://KnockKnock.readify.net")]
    [SerializableAttribute]
    public class ContactDetails : object, IExtensibleDataObject, INotifyPropertyChanged
    {
        [NonSerializedAttribute()]
        private ExtensionDataObject extensionDataField;

        [NonSerializedAttribute()]
        private string EmailAddressField;

        [OptionalFieldAttribute()]
        private string FamilyNameField;

        [OptionalFieldAttribute()]
        private string GivenNameField;

        [OptionalFieldAttribute()]
        private string PhoneNumberField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public ExtensionDataObject ExtensionData
        {
            get { return this.extensionDataField; }
            set
            {
                this.extensionDataField = value;
            }
        }

        [DataMemberAttribute()]
        public string EmailAddress
        {
            get { return this.EmailAddressField; }
            set
            {
                if ((object.ReferenceEquals(this.EmailAddressField, value) != true))
                {
                    this.EmailAddressField = value;
                    this.RaisePropertyChanged("EmailAddress");
                }
            }
        }

        [DataMemberAttribute()]
        public string FamilyName
        {
            get { return this.FamilyNameField; }
            set
            {
                if ((object.ReferenceEquals(this.FamilyNameField, value) != true))
                {
                    this.FamilyNameField = value;
                    this.RaisePropertyChanged("FamilyName");
                }
            }
        }

        [DataMemberAttribute()]
        public string GivenName
        {
            get { return this.GivenNameField; }
            set
            {
                if ((object.ReferenceEquals(this.GivenNameField, value) != true))
                {
                    this.GivenNameField = value;
                    this.RaisePropertyChanged("GivenName");
                }
            }
        }

        [DataMemberAttribute()]
        public string PhoneNumber
        {
            get { return this.PhoneNumberField; }
            set
            {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true))
                {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
