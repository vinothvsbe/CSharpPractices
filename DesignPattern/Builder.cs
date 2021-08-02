using System;
using System.Text;
namespace DesignPattern
{
    public class SQLFragments{
        public string ColumnName { get; set; }
        public string TableName { get; set; }

        public string Condition { get; set; }
        public SQLFragments()
        {
            
        }

        public SQLFragments(string columnName, string tableName, string condition)
        {
            ColumnName = columnName;
            TableName = tableName;
            Condition = condition;
        }

        public string PrintColumn(){
            return ColumnName.ToString();
        }

        public string PrintTableName(){
            return TableName.ToString();
        }

        public string PrintCondition(){
            return Condition.ToString();
        }

    }
    class SQLBuilder
    {   
        StringBuilder sb=new StringBuilder();
        SQLFragments sqlFragments;
        public SQLBuilder(){
            sqlFragments = new SQLFragments();
        }

        public SQLBuilder AddSelect(string columnName){
            sqlFragments.ColumnName = columnName;
            if(columnName!=string.Empty)
                sb.AppendLine("SELECT "+ sqlFragments.PrintColumn());
            return this;
        }

        public SQLBuilder AddTable(string tableName){
            sqlFragments.TableName = tableName;
            if(tableName!=string.Empty)
                sb.AppendLine("FROM "+ sqlFragments.PrintTableName());
            return this;
        }

        public SQLBuilder AddCondition(string condition){
            sqlFragments.Condition = condition;
            if(condition !=string.Empty)
                sb.AppendLine("WHERE "+sqlFragments.PrintCondition());
            return this;
        }
        public string Build(){
            return sb.ToString();
        }

    }
}