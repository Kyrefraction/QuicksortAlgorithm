// This has to be done a bit differently to the C# implementation, as Java has no passing by Reference
public class Controller <T extends Comparable<T>> {
	
    static Comparable[] unsortedInts = { 10, 2, 1, 4, 3, 6, 8, 7 }; // make the array of ints
    static Comparable[] unsortedChars = { 'a', 'z', 'y', 'c' }; // make the array of chars
    static Comparable[] unsortedStrings = { "z", "e", "x", "c", "m", "q", "a" }; // make the array of Strings
    
	public static <T extends Comparable<T>> void QuickSort(T[] items, int left, int right)
	{
	    int i = left; int j = right;
	    T pivot = items[left + (right - left) / 2];
	    T temp;

	    while (i <= j) {
	    	for(; ( items[i].compareTo(pivot) < 0) && (i < right); i++);
	    	for(; (pivot.compareTo(items[j]) < 0) && (j > left); j--);
	        if (i <= j) // swap
	        {
	            temp = items[i];
	            items[i] = items[j];
	            items[j] = temp;

	            i++;
	            j--;
	        }
	        if (left < j) QuickSort(items, left, j);
	        if (i < right) QuickSort(items, i, right);
	    }
	     
	}
	
	public static void PrintArray(Comparable[] Array) {
	    for(int i = 0; i < Array.length; i++){
	    	System.out.print(Array[i] + " ");
	    }
	}
	public static void Space() {
		System.out.println();
		System.out.println();
	}
	
	
	public static void main(String args[]){
		Controller controller = new Controller();
		
		System.out.println("Unsorted array of Chars");
		PrintArray(unsortedChars);
		Space();
		
	    controller.QuickSort(unsortedChars,0,unsortedChars.length - 1);
	    System.out.println("Sorted array of Chars");
		PrintArray(unsortedChars);
		Space();
		
		System.out.println("Unsorted array of Ints");
		PrintArray(unsortedInts);
		Space();
		
		System.out.println("Sorted array of Ints");
	    controller.QuickSort(unsortedInts,0,unsortedInts.length - 1);
	    PrintArray(unsortedInts);
	    System.out.println();
	    Space();
	    
		System.out.println("Unsorted array of Strings");
		PrintArray(unsortedStrings);
		Space();
		
		System.out.println("Sorted array of Strings");
	    controller.QuickSort(unsortedStrings,0,unsortedStrings.length - 1);
	    PrintArray(unsortedStrings);
	    System.out.println();
	}
}
