using Newtonsoft.Json;


string strJSON = @"{'itens':
[{
	'chassi':'9UWSHX73ABN001138',
	'cor_do_veiculo':'UU',
	'desc_cor':'BRANCO',
	'ano_f':2000,
	'ano_m':2011,
	'motor':'D4BHA056400',
	'tracao':'4X2',
	'versao_do_veiculo':'K77211',
	'desc_modelo':'UK2500 HD SC',
	'cnpj_do_br':'08715766000326',
	'modelo':'UK2500',
	'data_venda':'25/02/2011',
	'nf':207500,
	'valor_venda_kia':48510},
{
	'chassi':'9UWSHX73ABN001138',
	'cor_do_veiculo':'UU',
	'desc_cor':'BRANCO',
	'ano_f':2000,
	'ano_m':2011,
	'motor':'D4BHA056400',
	'tracao':'4X2',
	'versao_do_veiculo':'K77211',
	'desc_modelo':'UK2500 HD SC',
	'cnpj_do_br':'08715766000326',
	'modelo':'UK2500',
	'data_venda':'25/02/2011',
	'nf':207500,
	'valor_venda_kia':48510}
]}";



var dataSet = JsonConvert.DeserializeObject<DataSet>(strJSON);

//DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);

//DataTable dataTable = dataSet.Tables["Table1"];

//Console.WriteLine(dataTable.Rows.Count);
// 2

foreach (var item in dataSet.itens)
{
	Console.WriteLine("Class" + item.chassi.ToString());
	Console.WriteLine("cor do veiculo" + item.cor_do_veiculo.ToString());
	Console.WriteLine("Desc Cor" + item.desc_cor.ToString());
	Console.WriteLine("Ano F" + item.ano_f.ToString());
	Console.WriteLine("Ano M" + item.ano_m.ToString());
	Console.WriteLine("Motor" + item.motor.ToString());
	Console.WriteLine("Tração" + item.tracao.ToString());
	Console.WriteLine("Versão do Veículo" + item.versao_do_veiculo.ToString());
	Console.WriteLine("Desc modelo" + item.desc_modelo.ToString());
	Console.WriteLine("CNPJ do BR" + item.cnpj_do_br.ToString());
	Console.WriteLine("Data Venda" + item.data_venda.ToString());
	Console.WriteLine("NF" + item.nf.ToString());
	Console.WriteLine("Valor Venda Kia" + item.valor_venda_kia.ToString());

}



