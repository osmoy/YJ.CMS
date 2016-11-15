//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace YJ.CMS.Model.ViewModel
{
    using System;
    using System.Collections.Generic;

    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class NewsView
    {
        [DisplayName("新闻编号")]
        public int n_id { get; set; }
        [DisplayName("所属类别")]
        public int category_id { get; set; }

        [DisplayName("用户名称")]
        public int user_id { get; set; }

        [DisplayName("新闻标题"), Required(ErrorMessage = "新闻标题不能为空")]
        public string n_title { get; set; }

        [DisplayName("作者")]
        public string n_author { get; set; }

        [DisplayName("转载自")]
        public string n_form { get; set; }

        [DisplayName("内容"), Required(ErrorMessage = "新闻内容不能为空")]
        public string n_content { get; set; }

        public int n_sort_id { get; set; }
        public int n_click { get; set; }
        public int n_is_lock { get; set; }
        public DateTime add_time { get; set; }

        public virtual CategoryView Category { get; set; }
        public virtual UserInfoView UserInfo { get; set; }
    }
}
