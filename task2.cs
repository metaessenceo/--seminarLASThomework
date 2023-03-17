void writeSum(int start, int end) {
    int sum = recursiveSum(start, end);
    Console.WriteLine(sum);
}

int recursiveSum(int start, int end) {
    if (start < end) {
        int sum = start + recursiveSum(start + 1, end);
        return sum;
    }
    else {
        return end;
    }
}

int getNumberFromUser() {
    Console.WriteLine("Write a natural number:")
    string input = Console.ReadLine();
    int number = int.Parse(input);
    return number;
}

int start = getNumberFromUser();
int end = getNumberFromUser();
writeSum(start, end);
