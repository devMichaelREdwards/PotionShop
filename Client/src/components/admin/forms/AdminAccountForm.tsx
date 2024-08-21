import ActionButton from '../../common/input/ActionButton';
import { Form } from 'rsuite';
import { DisabledControl } from '../../common/input/FormControl';
import { useSubmit } from '../../../hooks/useSubmit';

const AdminAccountForm = () => {
    const { submitting, errors, submitForm } = useSubmit('', 'Account Saved', 'An error occurred! Please correct the errors and try again.');

    /*useEffect(() => {
        console.log(data);
    }, [data]);*/

    const handleSubmit = async () => {};

    return (
        <Form fluid>
            <Form.Group>
                <DisabledControl value={''} label='Name' name='name' error={errors?.name} />
            </Form.Group>

            <ActionButton
                appearance='ghost'
                label='Submit'
                color='green'
                action={() => {
                    handleSubmit();
                }}
            />
        </Form>
    );
};

export default AdminAccountForm;
