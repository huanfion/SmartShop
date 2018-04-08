using System;
using Abp.Domain.Entities;

namespace SmartShop.Core.Entities{
         //PhoneValid
        public class PhoneValid:Entity
    {

           
        /// <summary>
        /// Type
        /// </summary>
        public virtual string Type
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Phone
        /// </summary>
        public virtual string Phone
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// Code
        /// </summary>
        public virtual string Code
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// CreateTime
        /// </summary>
        public virtual DateTime? CreateTime
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// IsValid
        /// </summary>
        public virtual int? IsValid
        {
            get; 
            set; 
        } 
         
           
        /// <summary>
        /// ValidTime
        /// </summary>
        public virtual DateTime? ValidTime
        {
            get; 
            set; 
        } 
         
           
                public PhoneValid()
        {
        
        }
   
    }
    
}