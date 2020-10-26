#pragma once
#include "Orden.h"
#include "Archivo.h"
#include "Lista.h"

#include <string>
#include <chrono>  
#include <msclr\marshal_cppstd.h>

lista pokemonList;
Orden o;
std::string filePath;


namespace SortPokemon
{

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
		}

	protected:
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^ openButtom;
	protected:
	private: System::Windows::Forms::RichTextBox^ richTextBox1;
	private: System::Windows::Forms::OpenFileDialog^ openFileDialog1;

	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::Button^ buttonSSP;
	private: System::Windows::Forms::Button^ button1;
	private: System::Windows::Forms::Button^ button2;
	private: System::Windows::Forms::Button^ button3;
	private: System::Windows::Forms::Button^ button4;
	private: System::Windows::Forms::Button^ button5;
	private: System::Windows::Forms::Button^ button6;
	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::TextBox^ textBox1;

	protected:

	private:
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		System::ComponentModel::Container^ components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		void InitializeComponent(void)
		{
			this->openButtom = (gcnew System::Windows::Forms::Button());
			this->richTextBox1 = (gcnew System::Windows::Forms::RichTextBox());
			this->openFileDialog1 = (gcnew System::Windows::Forms::OpenFileDialog());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->buttonSSP = (gcnew System::Windows::Forms::Button());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->button3 = (gcnew System::Windows::Forms::Button());
			this->button4 = (gcnew System::Windows::Forms::Button());
			this->button5 = (gcnew System::Windows::Forms::Button());
			this->button6 = (gcnew System::Windows::Forms::Button());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->SuspendLayout();
			// 
			// openButtom
			// 
			this->openButtom->Location = System::Drawing::Point(12, 24);
			this->openButtom->Margin = System::Windows::Forms::Padding(3, 4, 3, 4);
			this->openButtom->Name = L"openButtom";
			this->openButtom->Size = System::Drawing::Size(129, 53);
			this->openButtom->TabIndex = 0;
			this->openButtom->Text = L"Open File";
			this->openButtom->UseVisualStyleBackColor = true;
			this->openButtom->Click += gcnew System::EventHandler(this, &MyForm::button1_Click);
			// 
			// richTextBox1
			// 
			this->richTextBox1->Location = System::Drawing::Point(12, 84);
			this->richTextBox1->Name = L"richTextBox1";
			this->richTextBox1->Size = System::Drawing::Size(580, 372);
			this->richTextBox1->TabIndex = 1;
			this->richTextBox1->Text = L"";
			// 
			// openFileDialog1
			// 
			this->openFileDialog1->FileName = L"openFileDialog1";
			this->openFileDialog1->Filter = L"CSV Files (*.csv)|*.csv";
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(652, 84);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(159, 20);
			this->label1->TabIndex = 3;
			this->label1->Text = L"Ordenar por Pokedex";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(652, 269);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(181, 20);
			this->label2->TabIndex = 4;
			this->label2->Text = L"Ordenar por Generacion";
			// 
			// buttonSSP
			// 
			this->buttonSSP->Location = System::Drawing::Point(656, 116);
			this->buttonSSP->Name = L"buttonSSP";
			this->buttonSSP->Size = System::Drawing::Size(155, 30);
			this->buttonSSP->TabIndex = 5;
			this->buttonSSP->Text = L"SelectionSort";
			this->buttonSSP->UseVisualStyleBackColor = true;
			this->buttonSSP->Click += gcnew System::EventHandler(this, &MyForm::buttonSSP_Click);
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(656, 302);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(155, 30);
			this->button1->TabIndex = 6;
			this->button1->Text = L"SelectionSort";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::button1_Click_1);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(456, 33);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(136, 44);
			this->button2->TabIndex = 7;
			this->button2->Text = L"Reset";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &MyForm::button2_Click);
			// 
			// button3
			// 
			this->button3->Location = System::Drawing::Point(656, 152);
			this->button3->Name = L"button3";
			this->button3->Size = System::Drawing::Size(155, 30);
			this->button3->TabIndex = 8;
			this->button3->Text = L"ShellSort";
			this->button3->UseVisualStyleBackColor = true;
			this->button3->Click += gcnew System::EventHandler(this, &MyForm::button3_Click);
			// 
			// button4
			// 
			this->button4->Location = System::Drawing::Point(656, 338);
			this->button4->Name = L"button4";
			this->button4->Size = System::Drawing::Size(155, 30);
			this->button4->TabIndex = 9;
			this->button4->Text = L"ShellSort";
			this->button4->UseVisualStyleBackColor = true;
			this->button4->Click += gcnew System::EventHandler(this, &MyForm::button4_Click);
			// 
			// button5
			// 
			this->button5->Location = System::Drawing::Point(656, 188);
			this->button5->Name = L"button5";
			this->button5->Size = System::Drawing::Size(155, 30);
			this->button5->TabIndex = 10;
			this->button5->Text = L"QuickSort";
			this->button5->UseVisualStyleBackColor = true;
			this->button5->Click += gcnew System::EventHandler(this, &MyForm::button5_Click);
			// 
			// button6
			// 
			this->button6->Location = System::Drawing::Point(656, 374);
			this->button6->Name = L"button6";
			this->button6->Size = System::Drawing::Size(155, 30);
			this->button6->TabIndex = 11;
			this->button6->Text = L"QuickSort";
			this->button6->UseVisualStyleBackColor = true;
			this->button6->Click += gcnew System::EventHandler(this, &MyForm::button6_Click);
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(266, 28);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(65, 20);
			this->label3->TabIndex = 12;
			this->label3->Text = L"Tiempo:";
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(270, 51);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(151, 26);
			this->textBox1->TabIndex = 13;
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(9, 20);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(960, 482);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->button6);
			this->Controls->Add(this->button5);
			this->Controls->Add(this->button4);
			this->Controls->Add(this->button3);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->button1);
			this->Controls->Add(this->buttonSSP);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->richTextBox1);
			this->Controls->Add(this->openButtom);
			this->Margin = System::Windows::Forms::Padding(3, 4, 3, 4);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e)
	{
		if (openFileDialog1->ShowDialog() == System::Windows::Forms::DialogResult::OK)
		{
			Archivo arch;
			
			std::string TextBoxContent;

			System::String^ fileDialogPath = openFileDialog1->FileName;
			filePath = msclr::interop::marshal_as<std::string>(fileDialogPath);

			pokemonList = arch.read_csv(filePath);
			TextBoxContent = pokemonList.Elementos();

			richTextBox1->Text = msclr::interop::marshal_as<System::String^>(TextBoxContent);
		}
	}

	private: System::Void buttonSSP_Click(System::Object^ sender, System::EventArgs^ e) 
	{
		//Selection Sort
		// start time
		auto start = std::chrono::high_resolution_clock::now();
		//Procedure
		Archivo arch;
		pokemonList = arch.read_csv(filePath);
		lista sortedList = o.SS_SortPokedex(pokemonList);
		//Imprimir resultado
		richTextBox1->Text = msclr::interop::marshal_as<System::String^>(sortedList.Elementos());
		// Record end time
		auto finish = std::chrono::high_resolution_clock::now();
		//Imprimir tiempo
		std::chrono::duration<double> elapsed = finish - start;
		std::string tiempo = std::to_string(elapsed.count() * 1000) + " milisegundos";
		textBox1->Text = msclr::interop::marshal_as<System::String^>(tiempo);
	}
	private: System::Void button1_Click_1(System::Object^ sender, System::EventArgs^ e) 
	{
		//Selectio Sort
		// start time
		auto start = std::chrono::high_resolution_clock::now();
		//Procedure
		Archivo arch;
		pokemonList = arch.read_csv(filePath);
		lista sortedList = o.SS_SortGeneration(pokemonList);
		richTextBox1->Text = msclr::interop::marshal_as<System::String^>(sortedList.Elementos());
		// Record end time
		auto finish = std::chrono::high_resolution_clock::now();
		//Imprimir tiempo
		std::chrono::duration<double> elapsed = finish - start;
		std::string tiempo = std::to_string(elapsed.count() * 1000) + " milisegundos";
		textBox1->Text = msclr::interop::marshal_as<System::String^>(tiempo);
	}
	private: System::Void button2_Click(System::Object^ sender, System::EventArgs^ e) 
	{
		//Default
		Archivo arch;
		pokemonList = arch.read_csv(filePath);
		richTextBox1->Text = msclr::interop::marshal_as<System::String^>(pokemonList.Elementos());
	}
	private: System::Void button3_Click(System::Object^ sender, System::EventArgs^ e) 
	{
		//Shell Sort
		// start time
		auto start = std::chrono::high_resolution_clock::now();
		//Procedure
		Archivo arch;
		pokemonList = arch.read_csv(filePath);
		lista sortedList = o.Sh_SortPokedex(pokemonList);
		richTextBox1->Text = msclr::interop::marshal_as<System::String^>(sortedList.Elementos());
		// Record end time
		auto finish = std::chrono::high_resolution_clock::now();
		//Imprimir tiempo
		std::chrono::duration<double> elapsed = finish - start;
		std::string tiempo = std::to_string(elapsed.count() * 1000) + " milisegundos";
		textBox1->Text = msclr::interop::marshal_as<System::String^>(tiempo);
	}
	private: System::Void button4_Click(System::Object^ sender, System::EventArgs^ e) 
	{
		//Shell Sort
		// start time
		auto start = std::chrono::high_resolution_clock::now();
		//Procedure
		Archivo arch;
		pokemonList = arch.read_csv(filePath);
		lista sortedList = o.Sh_SortGeneration(pokemonList);
		richTextBox1->Text = msclr::interop::marshal_as<System::String^>(sortedList.Elementos());
		// Record end time
		auto finish = std::chrono::high_resolution_clock::now();
		//Imprimir tiempo
		std::chrono::duration<double> elapsed = finish - start;
		std::string tiempo = std::to_string(elapsed.count() * 1000) + " milisegundos";
		textBox1->Text = msclr::interop::marshal_as<System::String^>(tiempo);
	}
	private: System::Void button5_Click(System::Object^ sender, System::EventArgs^ e) 
	{
		//Quick Sort
		// start time
		auto start = std::chrono::high_resolution_clock::now();
		//Procedure
		Archivo arch;
		pokemonList = arch.read_csv(filePath);
		o.Qs_SortPokedex(&pokemonList);
		richTextBox1->Text = msclr::interop::marshal_as<System::String^>(pokemonList.Elementos());
		// Record end time
		auto finish = std::chrono::high_resolution_clock::now();
		//Imprimir tiempo
		std::chrono::duration<double> elapsed = finish - start;
		std::string tiempo = std::to_string(elapsed.count() * 1000) + " milisegundos";
		textBox1->Text = msclr::interop::marshal_as<System::String^>(tiempo);
	}
	private: System::Void button6_Click(System::Object^ sender, System::EventArgs^ e) 
	{
		//Quick Sort
		// start time
		auto start = std::chrono::high_resolution_clock::now();
		//Procedure
		Archivo arch;
		pokemonList = arch.read_csv(filePath);
		o.Qs_SortGeneration(&pokemonList);
		richTextBox1->Text = msclr::interop::marshal_as<System::String^>(pokemonList.Elementos());
		// Record end time
		auto finish = std::chrono::high_resolution_clock::now();
		//Imprimir tiempo
		std::chrono::duration<double> elapsed = finish - start;
		std::string tiempo = std::to_string(elapsed.count() * 1000) + " milisegundos";
		textBox1->Text = msclr::interop::marshal_as<System::String^>(tiempo);
	}
};
}
