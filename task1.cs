void writeSmallerNumbers(int number) {
    recursiveNumberWriter(number);
}

void recursiveNumberWriter(int number) {
    if (number > 0) {
        Console.WriteLine(number);
        recursiveNumberWriter(number - 1);
    }
}


int number = 5;
writeSmallerNumbers(number);
