﻿using SQLite;

namespace MauiAppMinhasCompras.Models
{
    public class Produto
    {
        string _descricao;
        double _preco;
        double _quantidade;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao { 
            get => _descricao; 
            set
            {
                if (value == null)
                {
                    throw new Exception("A descrição não pode estar vazia");
                }
                _descricao = value;
            }
        }
        public double Quantidade { 
            get => _quantidade; 
            set 
            {
                if (value <= 0)
                {
                    throw new Exception("A quantidade deve ser maior que zero");
                }
                _quantidade = value;
            } 
        }
        public double Preco {
            get => _preco;
            set
            {
                if (value < 0)
                {
                    throw new Exception("O preço não pode ser negativo");
                }

                _preco = value;
            }
        }
        public double Total { get => Quantidade * Preco; }
    }
}
