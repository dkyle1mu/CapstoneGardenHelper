import { useEffect, useState } from 'react';
import './App.css';
import { Form, TextField, Label, Input, FieldError, Button } from 'react-aria-components';

function AddPlant(data) {
    fetch('https://localhost:14054/api/GardenController', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(data)
    })
}

function Create() {
    <Form>
        <TextField name="Name" isRequired>
            <Label>Name</Label>
            <Input />
            <FieldError />
        </TextField>
        <TextField name="WaterInterval" isRequired>
            <Label>Watering Interval (Hours):</Label>
            <Input />
            <FieldError />
        </TextField>
        <DateField name="PlantedDate">
            <Label>Date Planted:</Label>
            <DateInput>
                {(segment) => <DateSegment segment={segment} />}
            </DateInput>
        </DateField>
        <Button type="submit">Submit</Button>
    </Form>
}

function App() {

    const [gardenData, setGardenData] = useState([]);
    const [error, setError] = useState(null);
    const [isLoading, setIsLoading] = useState(true);



    useEffect(() => {
        const fetchData = async () => {
            try {
                const response = await fetch('https://localhost:14054/api/GardenController');
                if (!response.ok) {
                    throw new Error(`Error! Garden could not be loaded. Status: ${response.status}`);
                }

                const data = await response.json();
                setGardenData(data);
            } catch (error) {
                setError(error.message);
            } finally {
                setIsLoading(false)
            }
        };
        fetchData();
    }, []);

    if (isLoading) {
        return (
            <div>
                <img
                    src="./assets/loading.gif"
                    alt="Garden is Loading"
                />
            </div>
        );
    }

    if (error) {
        return (
            <div>
                <h1>Catastrophic Garden Related Error!</h1>
                {error}
            </div>
        );
    }



return (
        <div>
            {gardenData && gardenData.length === 0 ? (
               <section>
                    <h1>Welcome to Garden Helper!</h1>
                    <h4>Let's add your first plant.</h4>
                    <Create />
                </section>
                


            ) : (
            <div>
                <h1>Garden Loaded!</h1>
                { gardenData }
            </div >
            )
}
        </div>
    );

}

export default App;