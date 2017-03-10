using System;

public class InPlaceShuffle
{

   public void shuffle(int[] theArray) {
    // if it's 1 or 0 items, just return
    if (theArray.Length <= 1) return;

    // walk through from beginning to end
    for (int indexWeAreChoosingFor = 0; indexWeAreChoosingFor < theArray.Length; indexWeAreChoosingFor++) {

        // choose a random not-yet-placed item to place there
        // (could also be the item currently in that spot)
        // must be an item AFTER the current item, because the stuff
        // before has all already been placed
        int randomChoiceIndex = getRandom(indexWeAreChoosingFor, theArray.Length - 1);

        // place our random choice in the spot by swapping
        int valueAtIndexWeChoseFor = theArray[indexWeAreChoosingFor];
        theArray[indexWeAreChoosingFor] = theArray[randomChoiceIndex];
        theArray[randomChoiceIndex] = valueAtIndexWeChoseFor;
    }
}



    public int getRandom(int floor, int ceiling)
    {
        Random rand = new Random();
        return rand.Next((ceiling - floor) + 1) + floor;
    }

    public void Test()
    {
        int[] array=new[] { 1, 2, 3, 4, 5 };

        shuffle(array);

        foreach (var item in array)
        {
            Console.Write(item + ",");
        }
    }
}

