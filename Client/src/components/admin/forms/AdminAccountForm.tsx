import { useEffect, useState } from 'react';
import ActionButton from '../../common/input/ActionButton';
import { Form } from 'rsuite';
import { DisabledControl } from '../../common/input/FormControl';
import { useData } from '../../../hooks/useData';
import { useSubmit } from '../../../hooks/useSubmit';
import { IData } from '../../../types/IData';
import useAuth from '../../../hooks/useAuth';

const AdminAccountForm = () => {
    const { user } = useAuth();
    const { data, loading } = useData(user ? 'employee/account' : '', true);
    const { submitting, errors, submitForm } = useSubmit('', 'Account Saved', 'An error occurred! Please correct the errors and try again.');

    useEffect(() => {
        console.log(data);
    }, [data]);

    const handleSubmit = async () => {};

    if (loading || submitting) return <>Loading Screen...</>;
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
