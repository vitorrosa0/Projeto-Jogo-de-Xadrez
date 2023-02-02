﻿using System;
using System.Runtime.ConstrainedExecution;
using tabuleiro;
using xadrez_console.tabuleiro;

namespace xadrez
{
    internal class Dama : Peca
    {
        public Dama(Tabuleiro tab, Cor cor) : base(cor, tab)
        {

        }
        public override string ToString()
        {
            return "D";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //esquerda
            pos.definirValores(posicao.linha , posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.posicaoValida(pos) && podeMover(pos))
                {
                    break;
                }
                pos.definirValores(posicao.linha, posicao.coluna - 1);
            }
            //direita
            pos.definirValores(posicao.linha , posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.posicaoValida(pos) && podeMover(pos))
                {
                    break;
                }
                pos.definirValores(posicao.linha , posicao.coluna + 1);
            }
            //ne
            pos.definirValores(posicao.linha-1, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.posicaoValida(pos) && podeMover(pos))
                {
                    break;
                }
                pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
            }
            //acima
            pos.definirValores(posicao.linha - 1, posicao.coluna );
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.posicaoValida(pos) && podeMover(pos))
                {
                    break;
                }
                pos.definirValores(posicao.linha - 1, posicao.coluna);
            }
            //abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.posicaoValida(pos) && podeMover(pos))
                {
                    break;
                }
                pos.definirValores(posicao.linha + 1, posicao.coluna);
            }
            //so
            pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.posicaoValida(pos) && podeMover(pos))
                {
                    break;
                }
                pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
            }
            //se
            pos.definirValores(posicao.linha+1, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.posicaoValida(pos) && podeMover(pos))
                {
                    break;
                }
                pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
            }
            //no
            pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.posicaoValida(pos) && podeMover(pos))
                {
                    break;
                }
                pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
            }
            return mat;
        }
    }
}
