#pragma once
class Quicksort
{
	private:
		void intercambio(int* a, int* b);
		int dividir(int array[], int low, int high, int arrayLength);
		void sortArray(int array[], int low, int high, int arrayLength);

	public:
		void sort(int array[], int arrayLength);
};

