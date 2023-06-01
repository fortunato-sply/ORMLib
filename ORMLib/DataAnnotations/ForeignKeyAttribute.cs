namespace ORMLib.DataAnnotations;
public class ForeignKeyAttribute : Attribute
{
  public Type ForeignTable { get; set; }
  public ForeignKeyAttribute(Type foreignTable)
  => this.ForeignTable = foreignTable;

}