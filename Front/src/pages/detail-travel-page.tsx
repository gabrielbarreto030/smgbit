import moment from "moment";
import React from "react";
import { MdArrowBack, MdDelete } from "react-icons/md";
import { Link,NavigateFunction,useNavigate,useParams } from "react-router-dom";
import TravelModel from "../models/TravelModel";
import TravelService from "../services/travelsService";

const travelService=new TravelService();
interface DetailPageProps{
    id: any,
    navigate:NavigateFunction,
  }
  
interface DetailPageState {
  id: number,
  travel:TravelModel
}

export default function DetailTravelPage(){
    let params = useParams();
    let navigateDom = useNavigate();
 
    return (
        <div>
            <DetailPage  id={params.id} navigate={navigateDom}></DetailPage>
        </div>
    );
}

 class DetailPage extends React.Component<DetailPageProps,DetailPageState>{
    constructor(props:any){        
        super(props);
        this.state={id:0,travel:new TravelModel()}
        this.getTravelId()
    } 
  
   getTravelId=async()=>{   
         let result= await travelService.getTravelId(this.props.id);      
        this.setState({travel:result.data})     
    }

    deleteTravelId=async()=>{
     
        await travelService.deleteTravel(this.props.id);
        this.props.navigate('/viagens')
    
    }
    
  render(){

    return  <div>
        <div className="headerDetail">
        <h2 className='btVoltar' ><MdArrowBack/><Link to="/viagens"> <p>Voltar</p></Link></h2>
        <button onClick={(()=> this.deleteTravelId())} ><MdDelete/> <p>Delete</p></button>
        </div>
   
    <div className="detailTravel">
        <header >
        <h1>Viagem</h1>
     
        </header>
   
      <section>
      <div className="labelTravel">
          <h3>Origem</h3>
          <p>{this.state.travel.origem}</p>
      </div>
      <div  className="labelTravel">
          <h3>Data da Viagem</h3>
          <p>{moment(this.state.travel.dataViagem).format('DD/m/yyyy hh:mm')}</p>
      </div>
      <div  className="labelTravel">
          <h3>Tipo de Viagem</h3>
          <p>{this.state.travel.tipoViagem}</p>
      </div>
      <div  className="labelTravel">
          <h3>Destino</h3>
          <p>{this.state.travel.destino}</p>
      </div>
      <div  className="labelTravel">
          <h3>Numero da Viagem</h3>
          <p>{this.state.travel.numeroViagem}</p>
      </div>

      </section>
      <section>
      <div className="labelTravel">
          <h3>Motorista</h3>
          <p>{this.state.travel.motorista}</p>
      </div>
      <div  className="labelTravel">
          <h3>Placa</h3>
          <p>{this.state.travel.placa}</p>
      </div>
      <div  className="labelTravel">
          <h3>Entrega Nº</h3>
          <p>{this.state.travel.entregas}</p>
      </div>
      <div  className="labelTravel">
          <h3>Tipo de Veículo</h3>
          <p>{this.state.travel.tipoVeiculo}</p>
      </div>
      <div  className="labelTravel">
          <h3>Km Rodado</h3>
          <p>{this.state.travel.kmRodado}</p>
      </div>
      <div  className="labelTravel">
          <h3>Caixas Carregadas</h3>
          <p>{this.state.travel.caixasCarregadas}</p>
      </div>

      </section>
      <section className="border-none">
      <div className="labelTravel">
          <h3>Valor da viagem</h3>
          
          <p>{this.state.travel.valorViagem===0?'Indisponível':"R$ "+this.state.travel.valorViagem.toFixed(2)}</p>
      </div>
      <div  className="labelTravel">
          <h3>Tabela de frete</h3>
          <p>{this.state.travel.tabelaViagem===""?'Não registrada':this.state.travel.tabelaViagem}</p>
      </div>
  

      </section>
      
      

    </div>
</div>
  }
    
}


   
