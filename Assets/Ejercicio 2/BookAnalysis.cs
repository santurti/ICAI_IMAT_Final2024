using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using System.Linq;
using JetBrains.Annotations;
using System;
using System.Linq.Expressions;
using UnityEditor;
public class BookAnalysis : MonoBehaviour
{
    private static BookAnalysis _instance;
    // Start is called before the first frame update
    public void Start()
    {
        if (_instance != null)
        {
            Destroy(this);
        }
        else
        {
            _instance = this;
        }
    }
    public string GetMostProlific(List<Book> books)
    {
        Dictionary<string, int> Autors = new Dictionary<string, int>();
        foreach (Book book in books) {
            if (Autors.ContainsKey(book.Author))
            {
                Autors[book.Author]++;
            }
            else { Autors[book.Author] = 1; }
        }
        string MaxAutor = "a";
        int nbooks = 0;
        foreach ((string Autor, int nbook) in Autors){
            if (Autors[Autor] > nbooks)
            {
                nbooks = Autors[Autor];
                MaxAutor = Autor;
            }
        }
        return MaxAutor;
    }



    public int TotalBooksByGenere(List<Book> books, string genere)
    {
        int nbooks = 0;
        foreach (Book book in books) { 
            if (book.Genre == genere)
            {
                nbooks++;
            }
        }
        return nbooks;
    }

    public List<Book> GetBooksExcedingPageCount(List<Book> books, int pageCount) 
    { 
        List<Book> result = new List<Book>();
        foreach (Book book in books)
        {
            if (book.PageCount >= pageCount) { result.Add(book); }
        }
        return result;
    }

    public string GetBookTypeWithMoreBooks(List<Book> books )
    {
        
        int kidsBookNumber = 0;
        int AdultBookNumber = 0;
        foreach (Book book in books)
        {
            if (book.GetType() == typeof(KidBook)) { kidsBookNumber++; }
            else if (book.GetType() == typeof(AdultBook)) { AdultBookNumber++; }
        }
        if (kidsBookNumber == AdultBookNumber) { return "Adult and kid books are Equal"; }
        else if (kidsBookNumber < AdultBookNumber) { return "Adult books are more numerous"; }
        else { return "Kid books are more numerous"; }
    }
    
    } 
