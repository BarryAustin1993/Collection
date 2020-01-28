# Collection
Creating a class that is made to work like the built in list class.

(5 points): As a developer, I want to write documentation in a .txt file that describes the details and functionality of my – operator overload. 
I want to include details such as “syntax”, “parameters”, “return type”, and an example of it being used, with the output. 


Collection<T> operator -(Collection<T> one, Collection<T> two)

C# public static Collection<T> resultCollection = collectionOne - collectionTwo

PARAMETERS
collectionOne
The collection given to have inital values to your new collection.

collectionTwo
The collection to have values compared and taken from collectionOne.

RETURNS
this methood returns a new collection comprising of values from collectionOne that collectionTwo did not also contain.

IMPLEMENTS
Collection<string> resultCollection = collection1 - collection2;


//EXAMPLE:

//Arange
            Collection<string> collection1 = new Collection<string>() { "1", "3", "5", "7", "9" };
            Collection<string> collection2 = new Collection<string>() { "3", "5", "7" };
//Act
            Collection<string> resultCollection = collection1 - collection2;

	    string result = resultCollection.ToString();
	    Console.WriteLine("result");
	    Console.Readline();

/* This code example produces the following output:

	    "19"
