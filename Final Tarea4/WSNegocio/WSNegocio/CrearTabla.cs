using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

namespace Negocios
{
    public class CrearTabla
    {
        public StringBuilder crear(DataTable dt)
        {
            try
            {
                StringBuilder html = new StringBuilder();
                /**/
                html.Append("<center>");
                html.Append("<table class='table table-condensed' style='text-align:center'>");
                html.Append("<thead>");

                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<th style='text-align:center'>");
                    html.Append(column.ColumnName);
                    html.Append("</th>");
                }
                html.Append("</tr>");
                html.Append("</thead>");

                html.Append("<tbody>");

                //Building the Data rows.
                foreach (DataRow row in dt.Rows)
                {
                    html.Append("<tr>");
                    foreach (DataColumn column in dt.Columns)
                    {
                        html.Append("<td>");
                        html.Append(row[column.ColumnName]);
                        html.Append("</td>");
                    }
                    html.Append("</tr>");
                }

                html.Append("</tbody>");
                //Table end.
                html.Append("</table>");
                html.Append("</center>");

                //Append the HTML string to Placeholder.

                return html;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public StringBuilder crearRepFFVV(DataTable dt)
        {
            try
            {
                StringBuilder html = new StringBuilder();

                html.Append("<center>");
                html.Append("<table class='table table-condensed' style='text-align:center'>");
                html.Append("<thead>");

                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<th style='text-align:center' nowrap>");
                    html.Append(column.ColumnName);
                    html.Append("</th>");
                }
                html.Append("</tr>");
                html.Append("</thead>");

                html.Append("<tbody>");

                foreach (DataRow row in dt.Rows)
                {
                    html.Append("<tr>");
                    foreach (DataColumn column in dt.Columns)
                    {
                        html.Append("<td nowrap>");
                        html.Append(row[column.ColumnName]);
                        html.Append("</td>");
                    }
                    html.Append("</tr>");
                }

                html.Append("</tbody>");
                html.Append("</table>");
                html.Append("</center>");

                return html;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}