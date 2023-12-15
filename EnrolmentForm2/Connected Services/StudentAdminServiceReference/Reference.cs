﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnrolmentForm2.StudentAdminServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/EnrolmentAdminService")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateEnrolledField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StudentIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StudentNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateEnrolled {
            get {
                return this.DateEnrolledField;
            }
            set {
                if ((this.DateEnrolledField.Equals(value) != true)) {
                    this.DateEnrolledField = value;
                    this.RaisePropertyChanged("DateEnrolled");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StudentID {
            get {
                return this.StudentIDField;
            }
            set {
                if ((this.StudentIDField.Equals(value) != true)) {
                    this.StudentIDField = value;
                    this.RaisePropertyChanged("StudentID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StudentName {
            get {
                return this.StudentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentNameField, value) != true)) {
                    this.StudentNameField = value;
                    this.RaisePropertyChanged("StudentName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimetableEntry", Namespace="http://schemas.datacontract.org/2004/07/EnrolmentAdminService")]
    [System.SerializableAttribute()]
    public partial class TimetableEntry : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CourseIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CourseNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StudentIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StudentNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CourseID {
            get {
                return this.CourseIDField;
            }
            set {
                if ((this.CourseIDField.Equals(value) != true)) {
                    this.CourseIDField = value;
                    this.RaisePropertyChanged("CourseID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CourseName {
            get {
                return this.CourseNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CourseNameField, value) != true)) {
                    this.CourseNameField = value;
                    this.RaisePropertyChanged("CourseName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StudentID {
            get {
                return this.StudentIDField;
            }
            set {
                if ((this.StudentIDField.Equals(value) != true)) {
                    this.StudentIDField = value;
                    this.RaisePropertyChanged("StudentID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StudentName {
            get {
                return this.StudentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentNameField, value) != true)) {
                    this.StudentNameField = value;
                    this.RaisePropertyChanged("StudentName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StudentAdminServiceReference.IStudentAdmin")]
    public interface IStudentAdmin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentAdmin/NewStudent", ReplyAction="http://tempuri.org/IStudentAdmin/NewStudentResponse")]
        void NewStudent(int StudentID, string studentName, System.DateTime DateEnrolled);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentAdmin/NewStudent", ReplyAction="http://tempuri.org/IStudentAdmin/NewStudentResponse")]
        System.Threading.Tasks.Task NewStudentAsync(int StudentID, string studentName, System.DateTime DateEnrolled);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentAdmin/ViewStudent", ReplyAction="http://tempuri.org/IStudentAdmin/ViewStudentResponse")]
        EnrolmentForm2.StudentAdminServiceReference.Student[] ViewStudent();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentAdmin/ViewStudent", ReplyAction="http://tempuri.org/IStudentAdmin/ViewStudentResponse")]
        System.Threading.Tasks.Task<EnrolmentForm2.StudentAdminServiceReference.Student[]> ViewStudentAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentAdmin/StudentTimetable", ReplyAction="http://tempuri.org/IStudentAdmin/StudentTimetableResponse")]
        EnrolmentForm2.StudentAdminServiceReference.TimetableEntry[] StudentTimetable();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentAdmin/StudentTimetable", ReplyAction="http://tempuri.org/IStudentAdmin/StudentTimetableResponse")]
        System.Threading.Tasks.Task<EnrolmentForm2.StudentAdminServiceReference.TimetableEntry[]> StudentTimetableAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStudentAdminChannel : EnrolmentForm2.StudentAdminServiceReference.IStudentAdmin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StudentAdminClient : System.ServiceModel.ClientBase<EnrolmentForm2.StudentAdminServiceReference.IStudentAdmin>, EnrolmentForm2.StudentAdminServiceReference.IStudentAdmin {
        
        public StudentAdminClient() {
        }
        
        public StudentAdminClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StudentAdminClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentAdminClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentAdminClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void NewStudent(int StudentID, string studentName, System.DateTime DateEnrolled) {
            base.Channel.NewStudent(StudentID, studentName, DateEnrolled);
        }
        
        public System.Threading.Tasks.Task NewStudentAsync(int StudentID, string studentName, System.DateTime DateEnrolled) {
            return base.Channel.NewStudentAsync(StudentID, studentName, DateEnrolled);
        }
        
        public EnrolmentForm2.StudentAdminServiceReference.Student[] ViewStudent() {
            return base.Channel.ViewStudent();
        }
        
        public System.Threading.Tasks.Task<EnrolmentForm2.StudentAdminServiceReference.Student[]> ViewStudentAsync() {
            return base.Channel.ViewStudentAsync();
        }
        
        public EnrolmentForm2.StudentAdminServiceReference.TimetableEntry[] StudentTimetable() {
            return base.Channel.StudentTimetable();
        }
        
        public System.Threading.Tasks.Task<EnrolmentForm2.StudentAdminServiceReference.TimetableEntry[]> StudentTimetableAsync() {
            return base.Channel.StudentTimetableAsync();
        }
    }
}