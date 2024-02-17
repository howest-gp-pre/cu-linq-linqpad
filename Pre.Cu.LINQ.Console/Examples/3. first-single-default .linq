<Query Kind="Statements">
  <IncludeUncapsulator>false</IncludeUncapsulator>
</Query>

var names = new List<string> { "Tom", "Charles", "Harry", "Choki" };
var emptyNames = new List<string> { };

// First:
names.First().Dump("First");

// FirstOrDefault();
emptyNames.FirstOrDefault().Dump("First Or Default");

// will throw error
// emptyNames.First().Dump("First");

// Single:

// will throw error
//names
//	.Where(p => p.StartsWith('C')).Single()
//	.Dump("Single");

// will also throw error
//names
//	.Where(p => p.StartsWith('C')).SingleOrDefault()
//	.Dump("SingleOrDefault");

// zal null teruggeven als resultaat.
names
	.Where(p => p.StartsWith('Z')).SingleOrDefault()
	.Dump("SingleOrDefault");


