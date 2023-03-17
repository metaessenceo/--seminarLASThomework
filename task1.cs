void writeSmallerNumbers(int number) {
    recursiveNumberWriter(number);
}

void recursiveNumberWriter(int number) {
    if (number > 0) {
        Console.WriteLine(number);
        recursiveNumberWriter(number - 1);
    }
}

int getNumberFromUser() {
    Console.WriteLine("Write a natural number:")
    string input = Console.ReadLine();
    int number = int.Parse(input);
    return number;
}


int number = getNumberFromUser();
writeSmallerNumbers(number);
