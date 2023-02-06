
import { render, screen, waitFor } from '@testing-library/react';
import App from './App';

describe('PAGE TEST',()=>{

  test('Get travel list from API',async()=>{

    render(<App />);
    const travelsLink = screen.getByText('Minhas viagens');
    const excelLink = screen.getByText('Importar excel');

    expect(travelsLink).toBeInTheDocument();
    expect(excelLink).toBeInTheDocument();

    excelLink.click();

    await waitFor(()=>{
      expect(screen.getByText('Selecione ou coloque o arquivo aqui')).toBeInTheDocument();
    })
  })
})