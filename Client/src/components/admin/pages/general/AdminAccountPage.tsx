import { Content, Panel } from 'rsuite';
import useTitle from '../../../../hooks/useTitle';
import AdminHeader from '../../../common/header/AdminHeader';
import AdminAccountForm from '../../forms/AdminAccountForm';
import { useData } from '../../../../hooks/useData';

const AdminAccountPage = () => {
    useTitle('My Account');
    const { data, loading } = useData('employee/account', true);

    console.log(data);

    if (loading) return <>Loading Page...</>;
    return (
        <Panel className='admin-page'>
            <AdminHeader title='My Account' />
            <Content>
                <AdminAccountForm />
            </Content>
        </Panel>
    );
};

export default AdminAccountPage;
