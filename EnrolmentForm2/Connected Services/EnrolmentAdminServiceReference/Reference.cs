﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnrolmentForm2.EnrolmentAdminServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Enrolment1", Namespace="http://schemas.datacontract.org/2004/07/EnrolmentAdminService")]
    [System.SerializableAttribute()]
    public partial class Enrolment1 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CourseIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GradeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StudentIDField;
        
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
        public string Grade {
            get {
                return this.GradeField;
            }
            set {
                if ((object.ReferenceEquals(this.GradeField, value) != true)) {
                    this.GradeField = value;
                    this.RaisePropertyChanged("Grade");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EnrolmentAdminServiceReference.IEnrolmentAdmin")]
    public interface IEnrolmentAdmin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEnrolmentAdmin/EnrolStudent", ReplyAction="http://tempuri.org/IEnrolmentAdmin/EnrolStudentResponse")]
        void EnrolStudent(int studentID, int courseID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEnrolmentAdmin/EnrolStudent", ReplyAction="http://tempuri.org/IEnrolmentAdmin/EnrolStudentResponse")]
        System.Threading.Tasks.Task EnrolStudentAsync(int studentID, int courseID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEnrolmentAdmin/GetEnrolmentByCourseID", ReplyAction="http://tempuri.org/IEnrolmentAdmin/GetEnrolmentByCourseIDResponse")]
        EnrolmentForm2.EnrolmentAdminServiceReference.Enrolment1 GetEnrolmentByCourseID(int courseID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEnrolmentAdmin/GetEnrolmentByCourseID", ReplyAction="http://tempuri.org/IEnrolmentAdmin/GetEnrolmentByCourseIDResponse")]
        System.Threading.Tasks.Task<EnrolmentForm2.EnrolmentAdminServiceReference.Enrolment1> GetEnrolmentByCourseIDAsync(int courseID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEnrolmentAdmin/GetEnrolments", ReplyAction="http://tempuri.org/IEnrolmentAdmin/GetEnrolmentsResponse")]
        EnrolmentForm2.EnrolmentAdminServiceReference.Enrolment1[] GetEnrolments();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEnrolmentAdmin/GetEnrolments", ReplyAction="http://tempuri.org/IEnrolmentAdmin/GetEnrolmentsResponse")]
        System.Threading.Tasks.Task<EnrolmentForm2.EnrolmentAdminServiceReference.Enrolment1[]> GetEnrolmentsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEnrolmentAdminChannel : EnrolmentForm2.EnrolmentAdminServiceReference.IEnrolmentAdmin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EnrolmentAdminClient : System.ServiceModel.ClientBase<EnrolmentForm2.EnrolmentAdminServiceReference.IEnrolmentAdmin>, EnrolmentForm2.EnrolmentAdminServiceReference.IEnrolmentAdmin {
        
        public EnrolmentAdminClient() {
        }
        
        public EnrolmentAdminClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EnrolmentAdminClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EnrolmentAdminClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EnrolmentAdminClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void EnrolStudent(int studentID, int courseID) {
            base.Channel.EnrolStudent(studentID, courseID);
        }
        
        public System.Threading.Tasks.Task EnrolStudentAsync(int studentID, int courseID) {
            return base.Channel.EnrolStudentAsync(studentID, courseID);
        }
        
        public EnrolmentForm2.EnrolmentAdminServiceReference.Enrolment1 GetEnrolmentByCourseID(int courseID) {
            return base.Channel.GetEnrolmentByCourseID(courseID);
        }
        
        public System.Threading.Tasks.Task<EnrolmentForm2.EnrolmentAdminServiceReference.Enrolment1> GetEnrolmentByCourseIDAsync(int courseID) {
            return base.Channel.GetEnrolmentByCourseIDAsync(courseID);
        }
        
        public EnrolmentForm2.EnrolmentAdminServiceReference.Enrolment1[] GetEnrolments() {
            return base.Channel.GetEnrolments();
        }
        
        public System.Threading.Tasks.Task<EnrolmentForm2.EnrolmentAdminServiceReference.Enrolment1[]> GetEnrolmentsAsync() {
            return base.Channel.GetEnrolmentsAsync();
        }
    }
}