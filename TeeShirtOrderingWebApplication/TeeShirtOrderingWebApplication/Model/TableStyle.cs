using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeeShirtOrderingWebApplication.Model
{
    public class TableStyle
    {
        String inlineTableStyle = " <style> table { font-family: arial, sans-serif; border-collapse: collapse; width: 100%;} td, th { border: 1px solid #dddddd; text-align: left; padding: 8px; } tr: nth - child(even) { background - color: #dddddd; } </ style > ";

               public String InlineTableStyle { get; set; }
    }
}
