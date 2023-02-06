
import MyDropzone from '../components/drop-zone';
import {MdArrowBack} from 'react-icons/md';
import { Link } from 'react-router-dom';



function ExcelPage() {
    return (
      <div className="Excel">
        
        <h2 className='btVoltar' ><MdArrowBack/><Link to="/"> <p>Voltar</p></Link></h2>
      <div className='drag'>
      <h1>Importar excel</h1>
        <MyDropzone  ></MyDropzone>
      </div>
        
      </div>
    );
  }
  
  export default ExcelPage;
  