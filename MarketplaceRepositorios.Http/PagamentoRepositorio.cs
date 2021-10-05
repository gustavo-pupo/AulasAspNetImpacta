﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceRepositorios.Http
{
    public class PagamentoRepositorio
    {
        private readonly HttpClient httpClient = new HttpClient();
        private const string caminho = "pagamentos"; //http://localhost:57544/api/pagamentos

        public PagamentoRepositorio(string baseAddress)
        {
            httpClient.BaseAddress = new Uri(baseAddress.TrimEnd('/')+'/');
        }
        public async Task<List<PagamentoResponse>> ObterPorCartao(int idCartao)
        {
            using (var resposta = await httpClient.GetAsync($"{caminho}/cartao/{idCartao}"))
            {
                return await resposta.Content.ReadAsAsync<List<PagamentoResponse>>();
            }
        }

        public async Task<PagamentoResponse> Post(PagamentoRequest pagamento)
        {
            using (var resposta = await httpClient.PostAsJsonAsync(caminho, pagamento))
            {
                //resposta.EnsureSuccessStatusCode();
                return await resposta.Content.ReadAsAsync<PagamentoResponse>();
            }
        }
    }
}
