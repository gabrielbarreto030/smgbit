import ButtomHome from "../components/home-button";
import { MdUploadFile,MdLocalShipping } from 'react-icons/md';
import img from './../assets/truck.jpg';
import { Link } from "react-router-dom";

function HomePage() {
    return (
        
      <div className="Home">
        
        <img src={img} className="hdHome"/>
       
        <h1>Funções</h1>
     
        <div className="btHomeLayout">
        <Link to="/excel">  <ButtomHome name="Importar excel" icon={MdUploadFile}></ButtomHome></Link>
        <Link to="/viagens">   <ButtomHome name="Minhas viagens" icon={MdLocalShipping}></ButtomHome></Link> 
        </div>

       
      </div>
    );
  }
  
  export default HomePage;