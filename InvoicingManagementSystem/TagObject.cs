using System;

namespace InvoicingManagementSystem
{
    public class TagObject
    {
        public string goods_id { get; set; }
        public string goods_type { get; set; }
        public string goods_supplier { get; set; }
        public Action ReLoad { get; set; }
    }
}
