public class DynamicArray {
    private int[] array;
    private int length;
    private int capacity;

    public DynamicArray(int capacity) {
        this.array = new int[capacity];
        this.capacity = capacity;
        this.length = 0;
    }

    public int Get(int i) {
        return array[i];
    }

    public void Set(int i, int n) {
        array[i] = n;  // Fixed: Removed "return"
    }

    public void PushBack(int n) {
        if (this.GetSize() == this.GetCapacity()) { // Fixed: Use () to call methods
            this.Resize();
        }

        this.array[this.GetSize()] = n;
        length++;
    }

    public int PopBack() {
        if (this.GetSize() > 0) { // Fixed: Use () to call method
            this.length--;
        }
            return this.array[this.GetSize()]; // Fixed: Call GetSize() properly

    }

    private void Resize() {
        int[] new_array = new int[this.capacity * 2]; // Fixed: Use int[], not T[]
        
        for (int i = 0; i < this.length; i++) { // Fixed: Use 'length' not 'array.Length'
            new_array[i] = this.array[i];
        }

        this.array = new_array;
        this.capacity *= 2; // Update capacity
    }

    public int GetSize() {
        return this.length;
    }

    public int GetCapacity() {
        return this.capacity;
    }
}
