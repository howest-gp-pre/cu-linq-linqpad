<Query Kind="Statements">
  <IncludeUncapsulator>false</IncludeUncapsulator>
</Query>

string[] musos = { "Roger Waters", "David Gilmour", "Rick Wright", "Nick Mason" };
musos.OrderBy(m => m.Split().Last())
	.Dump("Sorted by last name"); // each musician name gets splitted, lastname is kept --> subquery