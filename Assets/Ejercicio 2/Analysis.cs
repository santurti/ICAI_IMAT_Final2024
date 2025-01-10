using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Linq;
using Unity.VisualScripting;

// SOLO ES NECESARIO DESCOMENTAR, NO MODIFICAR EL CÓDIGO.

/* 
   AÚN ASÍ, SI NO SE SABE HACER CORRECTAMENTE ALGÚNO DE LOS APARTADOS,
   SE PUEDE MODIFICAR EL CÓDIGO PARA UN CORRECTO FUNCIONAMIENTO.
*/
public class Analysis : MonoBehaviour
{
    List<TextMeshPro> textResults;
    List<Book> books;
    string bookType;
    int pageCountThreshold;

    //BookAnalysis bookAnalysis = BookAnalysis.Instance();

    private void Awake()
    {
        textResults = GetComponent<Results>().GetTextResults();
    }

    public void AnalyzeTest1()
    {
        books = new List<Book>
    {
        new Book(1, "1984", "George Orwell", "Fiction", 328),
        new Book(2, "Harry Potter and the Sorcerer's Stone", "J.K. Rowling", "Fiction", 309),
        new Book(3, "Brave New World", "Aldous Huxley", "Fiction", 311),
        new Book(4, "Matilda", "Roald Dahl", "Fiction", 240),
        new Book(5, "Sapiens: A Brief History of Humankind", "Yuval Noah Harari", "Non-Fiction", 443)
    };
        bookType = "Fiction";
        pageCountThreshold = 350;

        ShowResults();
    }

    public void AnalyzeTest2()
    {
        books = new List<Book>
        {
            /*
            new AdultBook(1, "The Wright Brothers", "David McCullough", "Non-Fiction", 320, "Medium"),
            new KidBook(2, "Charlie and the Chocolate Factory", "Roald Dahl", "Fiction", 190, 10),
            new AdultBook(3, "Sapiens: A Brief History of Humankind", "Yuval Noah Harari", "Non-Fiction", 443, "High"),
            new KidBook(4, "Matilda", "Roald Dahl", "Fiction", 240, 8),
            new KidBook(5, "The Lion, the Witch and the Wardrobe", "C.S. Lewis", "Fiction", 208, 8),
            new AdultBook(6, "The Catcher in the Rye", "J.D. Salinger", "Fiction", 277, "High"),
            new KidBook(7, "James and the Giant Peach", "Roald Dahl", "Fiction", 162, 9)
            */
        };

        bookType = "Non-Fiction";
        pageCountThreshold = 250;

        ShowResults();
    }

    void ShowResults()
    {
        //textResults[0].text = $"Total books in {bookType} genre: <b>{bookAnalysis.CalculateTotalBooksByGenre(books, bookType)}</b>";
        //textResults[1].text = $"Most prolific author: <b>{bookAnalysis.GetMostProlificAuthor(books)}</b>";
        //textResults[2].text = $"Books exceeding {pageCountThreshold} pages: <b>{string.Join(", ", bookAnalysis.GetBooksExceedingPageCount(books, pageCountThreshold))}</b>";
        //textResults[3].text = $"Comparison between adult and kid books: <b>{bookAnalysis.GetBookTypeWithMoreBooks(books)}</b>";
    }
}