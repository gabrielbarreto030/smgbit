

import {useCallback} from 'react'
import {useDropzone} from 'react-dropzone';
import * as excel from 'xlsx';
import * as XLSX from 'xlsx';
import TravelService from '../services/travelsService';
import { useNavigate } from 'react-router-dom';


const travelService=new TravelService();
function viagemExceltoJson(dataExcel:any):object{
  return {
    "dataViagem": dataExcel['Data Viagem'],
    "numeroViagem":dataExcel['Número Viagem'],
    "motorista":dataExcel['Motorista'],
    "placa":dataExcel['Placa'],
    "tipoVeiculo":dataExcel['Tipo de Veículo'],
    "origem":dataExcel['Operação'],
    "destino":dataExcel['Destino'],
    "caixasCarregadas":dataExcel['Caixas'],
    "entregas":dataExcel['Paradas']??dataExcel['Número Parada'],
    "kmRodado":dataExcel['Km Rodado'],
    "tipoViagem":dataExcel['Tipo de Viagem'],
    "tabelaViagem":"",
    "valorViagem":0
  };
}




function MyDropzone() {
  let navigateDom = useNavigate();
  var convertExcelToViagem=async (dataExcel:any[])=>{
  
    for(var e of dataExcel){
      await   travelService.postTravel(viagemExceltoJson(e))
    }  
    navigateDom('/viagens');
    }

    const onDrop = useCallback(async(acceptedFiles:any) =>{       
        const data=await acceptedFiles[0].arrayBuffer();
        const readOpts = { 
          cellText:false, 
          cellDates:true
        };
       var excelReaded= await excel.read(data,readOpts)       
        excelReaded.SheetNames.forEach(sheet => {       
        let valores = XLSX.utils.sheet_to_json(excelReaded.Sheets[sheet], 
            {header: 2,
             dateNF:'dd/mm/yyyy hh:mm',
           defval: "",           
          })         
           convertExcelToViagem(valores)
        
      })
    }, []);
    const {getRootProps, getInputProps, isDragActive} = useDropzone({onDrop})
  
    return (
      <div {...getRootProps()}   className="Drop">
        <input {...getInputProps()} />
        {
          isDragActive ?
            <p>coloque o arquivo aqui</p> :
            <p>Selecione ou coloque o arquivo aqui</p>
        }
      </div>
    )
  }


  export default MyDropzone;