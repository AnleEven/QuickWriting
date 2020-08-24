using QuickWriting.Common;
using QuickWriting.Common.Entity;
using QuickWriting.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuickWriting.Users.Dto
{
    public class UserDto: BaseDto
    {
        /// <summary>
        /// 登陆账户
        /// </summary>
        [Required]
        [DisplayName("登陆账户")]
        [Display(Name = "登陆账户")]
        [StringLength(FieldLimitBaseDto.MaxNameLength)]
        public string Account { get; set; }

        /// <summary>
        /// 登陆密码
        /// </summary>
        [Display(Name = "登陆密码")]
        [DisplayName("登陆密码")]
        [Description("登陆密码")]
        public string Password { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        [Display(Name = "真实姓名")]
        [DisplayName("真实姓名")]
        [Description("真实姓名")]
        [StringLength(FieldLimitBaseDto.MaxNameLength)]
        public string RealName { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [Display(Name = "昵称")]
        [DisplayName("昵称")]
        [Description("昵称")]
        [StringLength(FieldLimitBaseDto.MaxNameLength)]
        public string NickName { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [Display(Name = "手机号码")]
        [DisplayName("手机号码")]
        [Description("手机号码")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 电子邮箱
        /// </summary>
        [Display(Name = "电子邮箱")]
        [DisplayName("电子邮箱")]
        [Description("电子邮箱")]
        public string MailBox { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        [Display(Name = "身份证号码")]
        [DisplayName("身份证号码")]
        [Description("身份证号码")]
        public string IDCard { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [Display(Name = "性别")]
        [DisplayName("性别")]
        [Description("性别")]
        public Gender Gender { get; set; }

        /// <summary>
        /// QQ号
        /// </summary>
        [Display(Name = "QQ号")]
        [DisplayName("QQ号")]
        [Description("QQ号")]
        public string QICQ { get; set; }

        /// <summary>
        /// 微信号
        /// </summary>
        [Display(Name = "微信号")]
        [DisplayName("微信号")]
        [Description("微信号")]
        public string WeChat { get; set; }

        /// <summary>
        /// 微信OpenId
        /// </summary>
        [Display(Name = "微信OpenId")]
        [DisplayName("微信OpenId")]
        [Description("微信OpenId")]
        public string OpenId { get; set; }

        /// <summary>
        /// 允许登陆类型
        /// </summary>
        [Display(Name = "允许登陆类型")]
        [DisplayName("允许登陆类型")]
        [Description("允许登陆类型")]
        public LoginType LoginType { get; set; }
        
        /// <summary>
        /// 上次登陆时间
        /// </summary>
        public DateTime LastLoginTime { get; set; }
    }
}
