<Query Kind="Statements">
  <IncludeUncapsulator>false</IncludeUncapsulator>
</Query>

string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

var query = names
	.Where(n => n.EndsWith("y"))
	.OrderBy(n => n.Length)
	.Select(n => n.ToUpper());

query.Dump("names ending with y");