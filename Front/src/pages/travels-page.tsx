import { MdArrowBack, MdArrowForwardIos } from "react-icons/md";

import React from 'react';
import { Link } from "react-router-dom";
import moment from "moment";
import TravelModel from "../models/TravelModel";
import TravelService from "../services/travelsService";

const travelService=new TravelService();
interface TravelsState{
   travels:TravelModel[];
}


export default class TravelsPage extends React.Component<{},TravelsState>{
  constructor(props:any){
    super(props);
    this.state={travels:[]}
    this.getTravels();
  }

   getTravels=async()=>{  
    var result = await travelService.getTravels();    
    this.setState({travels:result.data}) 
  }



  render(){
    return   <div className="Viagens">
    <h2  className="btVoltar"><MdArrowBack/><Link to="/"> <p>Voltar</p></Link></h2>
 <div className="Container">
 <h1>Minhas viagens</h1>
   <header className="travelInfo">
       <p>ORIGEM</p>
       <p>DESTINO</p>
       <p>MOTORISTA</p>
       <p>DATA DA VIAGEM</p>
       <p>VALOR</p>
       <p></p>
   </header>
      {this.state.travels.map((e)=>(       
        <Link  to={"/viagens/"+e.id} className="travelInfo cardTravel" key={e.id}>
        <p >{e.origem}</p>
        <p >{e.destino}</p>
        <p >{e.motorista}</p>
        <p >{moment(e.dataViagem).format('DD/m/yyyy')}</p>
       <p >R$ {e.valorViagem.toFixed(2)}</p>
       <p>          
    <MdArrowForwardIos/> </p>
      </Link>
     ))}
 
 
 </div>

  
 </div>
  }
}


