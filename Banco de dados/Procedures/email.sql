use Estacionamento
go

execute sp_configure 'Show Advanced Options', 1
reconfigure
execute sp_configure 'Database Mail XPs', 1
reconfigure


-- Acessar o email e configurar aplicativos externos no gmail e acesso a app menos seguro

execute msdb.dbo.sysmail_add_account_sp
--Dados fixos
@mailserver_name = 'smtp.gmail.com',/*Servidor do email*/
@port = 587,/*Porta do servidor*/
@enable_ssl = 1,
/*Dados da minha conta*/
@account_name = 'emailEstacionamento',
@display_name = 'Estacionamento Alfa Park',
@email_address = 'estacionamentoalfapark10@gmail.com',
@username = 'estacionamentoalfapark10@gmail.com',
@password = 'glvnfoapxvpkzlyi'
/*Adicionar perfil*/
execute msdb.dbo.sysmail_add_profile_sp
@profile_name = 'Estacionamento_perfil',
@description = 'Perfil para	enviar o pagamento'
/*Perfil na conta*/
execute msdb.dbo.sysmail_add_profileaccount_sp
@profile_name = 'Estacionamento_perfil',
@account_name = 'emailEstacionamento',
@sequence_number = 1

execute msdb.dbo.sp_send_dbmail
@profile_name = 'Estacionamento_perfil',
@recipients = 'mandrakeguizao@gmail.com',/*Email que vai ser enviado*/
@subject = 'Esse email é um teste',/*Titulo do texto*/
@body = 'Ola teste de email ' /*Mensagem do texto
*/


--selecionar contas cadastradas
select * from msdb.dbo.sysmail_account

--selecionar perfis cadastrados
select * from msdb.dbo.sysmail_profile

--selecionar email enviados
select * from msdb.dbo.sysmail_log

-- excluir conta e perfil
execute msdb.dbo.sysmail_delete_account_sp @account_name = 'emailEstacionamento'
execute msdb.dbo.sysmail_delete_profile_sp @profile_name = 'Estacionamento_Perfil'
 