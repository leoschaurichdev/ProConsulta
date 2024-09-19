﻿using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using ProConsulta.Models;
using ProConsulta.Repositories.Especialidades;
using ProConsulta.Repositories.Medicos;
using ProConsulta.Components.Pages.Medicos;
using ProConsulta.Extensions;

namespace ProConsulta.Components.Pages.Medicos
{
    public class CreateMedicoPage : ComponentBase
    {
        [Inject]
        private IEspecialidadeRepository EspecialidadeRepository { get; set; } = null!;

        [Inject]
        private IMedicoRepository repository { get; set; } = null!;

        [Inject]
        public ISnackbar Snackbar { get; set; } = null!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = null!;

        public List<Especialidade> Especialidades { get; set; } = new List<Especialidade>();

        public MedicoInputModel InputModel { get; set; } = new MedicoInputModel();

        public async Task OnValidSubmitAsync(EditContext editContext)
        {
            try
            {
                if (editContext.Model is MedicoInputModel model)
                {
                    var medico = new Medico
                    {
                        Nome = model.Nome,
                        Documento = model.Documento.SomenteCaracteres(),
                        Celular = model.Celular.SomenteCaracteres(),
                        Crm = model.Crm.SomenteCaracteres(),
                        EspecialidadeId = model.EspecialidadeId,
                        DataCadastro = model.DataCadastro
                    };
                    await repository.AddAsync(medico);
                    Snackbar.Add($"Médico {medico.Nome} cadastrado com sucesso!", Severity.Success);
                    NavigationManager.NavigateTo("/medicos");// Voltando para a tela de médicos
                }
            }
            catch (Exception ex)
            {
                Snackbar.Add(ex.Message, Severity.Error);
            }
        }

        protected override async Task OnInitializedAsync()
        {
            Especialidades = await EspecialidadeRepository.GetAllAsync();
        }

    }
}
